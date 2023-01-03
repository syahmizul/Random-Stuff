using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppMakmal4G1
{
    class InvalidHadUmur : Exception
    {
        public InvalidHadUmur() : base("Umur melebihi had")
        {

        }

        public InvalidHadUmur(String mesej):base(mesej)
        {

        }
    }
}
