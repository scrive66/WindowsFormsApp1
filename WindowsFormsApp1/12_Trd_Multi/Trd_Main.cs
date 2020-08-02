using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1._12_Trd_Multi
{
    class Trd_Main
    {
        private const int STATE_CHANGE_SLEEP_TIME = 100;
        private const int WAITING_SLEEP_TIME = 100;

        /// <summary>
        /// メイン状態遷移
        /// </summary>
        public enum STATE_MAIN
        {
            /// <summary>
            /// 初期化中
            /// </summary>
            Initializing,
            /// <summary>
            /// 原点復帰待ち
            /// </summary>
            WaitingForReturningOrigin,
            /// <summary>
            /// 原点復帰中
            /// </summary>
            ReturningOrigin,
            /// <summary>
            /// 原位置移動待ち
            /// </summary>
            WaitingForMovingHomePosition,
            /// <summary>
            /// 原位置移動中
            /// </summary>
            MovingHomePosition,
            /// <summary>
            /// 自動開始待ち
            /// </summary>
            WaitingForProducing,
            /// <summary>
            /// 自動中
            /// </summary>
            Producing,
            /// <summary>
            /// 手動中
            /// </summary>
            OperatingManually,
            /// <summary>
            /// エラー解除待ち
            /// </summary>
            WaitingForErrorRelease,
            /// <summary>
            /// 終了中
            /// </summary>
            Ending,
        }

        public STATE_MAIN CurrentState { get; private set; }
        public Action<string> Messenger { get; set; }

        public bool ShouldEndSoftware { get; set; } = false;

        private readonly Trd_Multi Trd_MultiObj;

        public Trd_Main(Trd_Multi trd_MultiObj)
        {
            Trd_MultiObj = trd_MultiObj;
        }

        private STATE_MAIN _PrevState;
        private STATE_MAIN _NextState;

        public void Start()
        {
            Task.Run(new Action(() =>
            {
                StateTask();
            }));
        }

        private void StateTask()
        {
            while (true)
            {
                try
                {
                    switch (CurrentState)
                    {
                        case STATE_MAIN.Initializing:
                            Initialize();
                            break;
                        case STATE_MAIN.WaitingForReturningOrigin:
                            WaitForReturningOrigin();
                            break;
                        case STATE_MAIN.ReturningOrigin:
                            ReturnOrigin();
                            break;
                        case STATE_MAIN.WaitingForMovingHomePosition:
                            WaitForMovingHomePosition();
                            break;
                        case STATE_MAIN.MovingHomePosition:
                            MoveHomePosition();
                            break;
                        case STATE_MAIN.WaitingForProducing:
                            WaitForProducing();
                            break;
                        case STATE_MAIN.Producing:
                            Produce();
                            break;
                        case STATE_MAIN.OperatingManually:
                            OperateManually();
                            break;
                        case STATE_MAIN.WaitingForErrorRelease:
                            WaitForErrorRelease();
                            break;
                        case STATE_MAIN.Ending:
                            End();
                            return;
                        default:
                            _NextState = STATE_MAIN.WaitingForErrorRelease;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    _NextState = STATE_MAIN.WaitingForErrorRelease;
                }

                _PrevState = CurrentState;

                AddLog($"{CurrentState} => {_NextState}");

                CurrentState = _NextState;

                Thread.Sleep(STATE_CHANGE_SLEEP_TIME);
            }
        }

        private void Initialize()
        {
            Trd_MultiObj.Init();

            Thread.Sleep(500);

            _NextState = STATE_MAIN.WaitingForReturningOrigin;
            return;
        }
        private void WaitForReturningOrigin()
        {
            while (true)
            {
                if (NeedChangeState())
                {
                    return;
                }

                if (Trd_MultiObj.IsStartPbOn)
                {
                    break;
                }

                Thread.Sleep(WAITING_SLEEP_TIME);
            }

            _NextState = STATE_MAIN.ReturningOrigin;
            return;
        }
        private void ReturnOrigin()
        {
            Thread.Sleep(500);

            _NextState = STATE_MAIN.WaitingForMovingHomePosition;
            return;
        }

        private void WaitForMovingHomePosition()
        {
            while (true)
            {
                if (NeedChangeState())
                {
                    return;
                }

                if (Trd_MultiObj.IsStartPbOn)
                {
                    break;
                }

                Thread.Sleep(WAITING_SLEEP_TIME);
            }

            _NextState = STATE_MAIN.MovingHomePosition;
            return;
        }

        private void MoveHomePosition()
        {
            Thread.Sleep(500);

            _NextState = STATE_MAIN.WaitingForProducing;
            return;
        }

        private void WaitForProducing()
        {
            while (true)
            {
                if (NeedChangeState())
                {
                    return;
                }

                if (Trd_MultiObj.IsStartPbOn)
                {
                    break;
                }

                Thread.Sleep(WAITING_SLEEP_TIME);
            }

            _NextState = STATE_MAIN.Producing;
            return;
        }

        private void Produce()
        {
            Thread.Sleep(500);

            _NextState = STATE_MAIN.WaitingForProducing;
            return;
        }

        private void OperateManually()
        {
            Thread.Sleep(500);

            _NextState = STATE_MAIN.WaitingForReturningOrigin;
            return;
        }

        private void WaitForErrorRelease()
        {
            while (true)
            {
                if (ShouldEndSoftware)
                {
                    _NextState = STATE_MAIN.Ending;
                    return;
                }

                if (Trd_MultiObj.IsResetPbOn)
                {
                    break;
                }

                Thread.Sleep(WAITING_SLEEP_TIME);
            }

            _NextState = STATE_MAIN.WaitingForReturningOrigin;
            return;
        }

        private void End()
        {
            Application.Exit();
            return;
        }

        private void AddLog(string message)
        {
            Messenger?.Invoke(message);
        }

        private bool NeedChangeState()
        {
            if (ShouldEndSoftware)
            {
                _NextState = STATE_MAIN.Ending;
                return true;
            }

            if (Trd_MultiObj.IsEmgergency)
            {
                _NextState = STATE_MAIN.WaitingForErrorRelease;
                return true;
            }

            return false;
        }
    }
}
