using System;
using System.Collections.Generic;
using System.Text;

namespace wh4Shop.AppCore.Const
{
    public static class GlobalConst
    {
        public static class LicenceType
        {
            public static string DEMO { get { return "DEMO"; } }
            public static string ONE_MONTH { get { return "ONE-MONTH"; } }
            public static string THREE_MONTH { get { return "THREE-MONTH"; } }
            public static string HALFOFYEAR { get { return "HALFOFYEAR"; } }
            public static string AYEAR { get { return "AYEAR"; } }
        }


        public static class ItemType
        {
            public static string CONSUMER { get { return "CONSUMER"; } }
            public static string TOOL { get { return "TOOL"; } }
            public static string FURNITURE { get { return "FURNITURE"; } }
            public static string HITECH { get { return "HI-TECH"; } }
            public static string APPLIANCES { get { return "APPLIANCES"; } }
        }
    }
}
