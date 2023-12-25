using System;

namespace TarkovKar
{
    internal class MySqlCommand
    {
        private string v;
        private MySqlConnection mySqlConnection;

        public MySqlCommand(string v)
        {
            this.v = v;
        }

        public MySqlCommand(string v, MySqlConnection mySqlConnection)
        {
            this.v = v;
            this.mySqlConnection = mySqlConnection;
        }

        public object Parameters { get; internal set; }
        public MySqlConnection Connection { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}