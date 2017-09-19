using System;
using System.Collections.Generic;
using System.Timers;
using Microsoft.VisualBasic.Devices;

namespace PortDataMapping
{
    public class SearchSerialPort : IDisposable
    {
        private Timer m_Timer;
        private int m_SerialPortCount = 0;
        private Computer m_Computer;

        public delegate void SerialPortCountChangedHandler(string[] PortNames);

        private event SerialPortCountChangedHandler m_SerialPortCountChanged;
        public event SerialPortCountChangedHandler SerialPortCountChanged
        {
            add
            {
                m_SerialPortCountChanged += value;
            }
            remove
            {
                if (m_SerialPortCountChanged != null)
                {
                    m_SerialPortCountChanged -= value;
                }
            }
        }

        public SearchSerialPort(int intervalueTime)
        {
            m_Computer = new Computer();
            m_Timer = new Timer(intervalueTime);
            m_Timer.AutoReset = true;
            m_Timer.Elapsed += TimerElapsed;
        }

        public void SetIntervalueTime(int intervalueTime)
        {
            m_Timer.Interval = intervalueTime;
        }

        public void Start()
        {
            m_Timer.Start();
        }

        public void Stop()
        {
            m_Timer.Stop();
        }

        private List<string> m_serialPortNames = new List<string>();

        public List<string> SerialPortNames
        {
            get { return m_serialPortNames; }
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (m_SerialPortCount != m_Computer.Ports.SerialPortNames.Count)
            {
                m_SerialPortCount = m_Computer.Ports.SerialPortNames.Count;
                m_serialPortNames.Clear();
                m_serialPortNames.AddRange(m_Computer.Ports.SerialPortNames);
                m_SerialPortCountChanged(m_serialPortNames.ToArray());
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    m_Timer.Stop();
                    m_Timer.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                m_Timer = null;
                m_Computer = null;
                m_serialPortNames = null;
                m_SerialPortCount = 0;
                m_SerialPortCountChanged = null;

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~SearchSerialPort() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}