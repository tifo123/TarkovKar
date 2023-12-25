using System;
using System.Data;

namespace TarkovKar
{
    internal class MySqlConnection
    {
        public MySqlConnection(string v)
        {
            V = v;
        }

        public string V { get; }
        public ConnectionState State { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}