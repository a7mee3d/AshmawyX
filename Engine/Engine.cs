using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AshmawyX
{
    public class Engine
    {
        public IntPtr MainHandle { get; set; }
        public IntPtr SecondHandle { get; set; }

        public bool EnableDelay { get; set; } = true;
        public double MinDelay { get; set; } = 0.2;
        public double MaxDelay { get; set; } = 0.8;

        public bool ChatBlock { get; set; } = true;
        public List<Keys> BlockedKeys { get; set; } = new List<Keys>();

        private Thread workerThread;
        private bool running = false;
        private bool paused = false;

        // ---------------------------------------------------------
        // DEFAULT MIRROR KEYS (YOUR REQUIREMENTS)
        // ---------------------------------------------------------
        private readonly Keys[] DefaultMirrorKeys =
        {
            // Numbers
            Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4,
            Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,

            // NumPad
            Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4,
            Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9,

            // F1–F6
            Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6,

            // Shift keys
            Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey
        };

        // ---------------------------------------------------------
        // WIN32 API
        // ---------------------------------------------------------
        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const uint WM_KEYDOWN = 0x0100;
        private const uint WM_KEYUP = 0x0101;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        private bool IsKeyPressed(Keys key)
        {
            return (GetAsyncKeyState(key) & 0x8000) != 0;
        }

        // ---------------------------------------------------------
        // START ENGINE
        // ---------------------------------------------------------
        public void Start()
        {
            if (running)
                return;

            running = true;
            paused = false;

            workerThread = new Thread(EngineLoop);
            workerThread.IsBackground = true;
            workerThread.Start();
        }

        // ---------------------------------------------------------
        // PAUSE ENGINE
        // ---------------------------------------------------------
        public void Pause()
        {
            paused = true;
        }

        // ---------------------------------------------------------
        // STOP ENGINE
        // ---------------------------------------------------------
        public void Stop()
        {
            running = false;
            paused = false;

            if (workerThread != null && workerThread.IsAlive)
                workerThread.Join();
        }

        // ---------------------------------------------------------
        // MAIN LOOP (CORRECTED MIRROR LOGIC)
        // ---------------------------------------------------------
        private void EngineLoop()
        {
            while (running)
            {
                if (paused)
                {
                    Thread.Sleep(20);
                    continue;
                }

                // Mirror default keys
                foreach (Keys key in DefaultMirrorKeys)
                {
                    if (IsKeyPressed(key))
                    {
                        if (ChatBlock && key == Keys.Enter)
                            continue;

                        MirrorKey(key);
                    }
                }

                // Mirror user-added keys
                foreach (Keys key in BlockedKeys)
                {
                    if (IsKeyPressed(key))
                        MirrorKey(key);
                }

                Thread.Sleep(1);
            }
        }

        // ---------------------------------------------------------
        // MIRROR KEY TO BOTH CLIENTS
        // ---------------------------------------------------------
        private void MirrorKey(Keys key)
        {
            // Send to main
            PostMessage(MainHandle, WM_KEYDOWN, (IntPtr)key, IntPtr.Zero);
            PostMessage(MainHandle, WM_KEYUP, (IntPtr)key, IntPtr.Zero);

            // Optional delay
            if (EnableDelay)
            {
                double delay = RandomDelay();
                Thread.Sleep((int)(delay * 1000));
            }

            // Send to second
            PostMessage(SecondHandle, WM_KEYDOWN, (IntPtr)key, IntPtr.Zero);
            PostMessage(SecondHandle, WM_KEYUP, (IntPtr)key, IntPtr.Zero);
        }

        // ---------------------------------------------------------
        // RANDOM DELAY
        // ---------------------------------------------------------
        private double RandomDelay()
        {
            Random r = new Random();
            return MinDelay + (r.NextDouble() * (MaxDelay - MinDelay));
        }
    }
}
