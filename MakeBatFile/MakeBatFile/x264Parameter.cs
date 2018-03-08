using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakeBatFile
{
    class x264Parameter
    {
        #region 参数
        Dictionary<string, string> dicParameter = new Dictionary<string, string>();

        private string _preset = string.Empty;
        private string _crf = string.Empty;
        private string _subme = string.Empty;
        private string _me = string.Empty;
        private string _merange = string.Empty;
        private string _trellis = string.Empty;

        public string preset
        {
            get { return _preset; }
            set { _preset = value; }
        }

        public string crf
        {
            get { return _crf; }
            set { _crf = value; }
        }

        public string subme
        {
            get { return _subme; }
            set { _subme = value; }
        }

        public string me
        {
            get { return _me; }
            set { _me = value; }
        }

        public string merange
        {
            get { return _merange; }
            set { _merange = value; }
        }

        public string trellis
        {
            get { return _trellis; }
            set { _trellis = value; }
        }
        #endregion

        public x264Parameter()
        {
        }

        #region 设置参数
        public void EndSetParameter()
        {
            dicParameter.Clear();
            //添加顺序对直接影响参数顺序
            dicParameter.Add("preset", _preset);
            dicParameter.Add("crf", _crf);
            dicParameter.Add("subme", _subme);
            dicParameter.Add("me", _me);
            dicParameter.Add("merange", _merange);
            dicParameter.Add("trellis", _trellis);
        }

        public void BeginSetParameter()
        {
            _preset = string.Empty;
            _crf = string.Empty;
            _subme = string.Empty;
            _me = string.Empty;
            _merange = string.Empty;
            _trellis = string.Empty;
        }
        #endregion

        public string GetParameterStr()
        {
            string strParameter = "";

            foreach (string key in dicParameter.Keys)
            {
                if (!string.IsNullOrEmpty(dicParameter[key]))
                {
                    string tmpParameter = " --" + key + " " + dicParameter[key];
                    strParameter += tmpParameter;
                }
            }

            return strParameter;
        }

        public string GetNameStr()
        {
            string strName = "";

            foreach (string key in dicParameter.Keys)
            {
                if (!string.IsNullOrEmpty(dicParameter[key]))
                {
                    if (key == "preset" || key == "me")
                    {
                        string tmpName = "[" + dicParameter[key] + "]";
                        strName += tmpName;
                    }
                    else
                    {
                        string tmpName = "[" + key + "_" + dicParameter[key] + "]";
                        strName += tmpName;
                    }
                }
            }

            return strName;
        }
    }
}
