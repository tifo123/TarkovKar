using System;
using System.Data;

namespace TarkovKar
{
    internal class MySqlDataAdapter
    {
        public MySqlCommand SelectCommand { get; internal set; }

        internal void Fill(DataTable table)
        {
            throw new NotImplementedException();
        }
    }
}