using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TransactionResult
    {
        private bool _isOk;
        private int _id;
        private string _error;

        public Boolean IsOk
        {
            set
            {
                this._isOk = value;
            }
            get
            {
                return this._isOk;
            }
        }
        public int Id
        {
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Error
        {
            set
            {
                this._error = value;
            }
            get
            {
                return this._error;
            }
        }
    }
}
