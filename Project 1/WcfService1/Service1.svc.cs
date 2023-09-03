﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int c2f(int c)
        {
            return Convert.ToInt32(Math.Round(Convert.ToDouble(c) * 9 / 5) + 32);
        }

        public int f2c(int f)
        {
            return Convert.ToInt32(Math.Round(Convert.ToDouble(f - 32) * 5 / 9));
        }

        public string sort(string s)
        {
            try {
                List<double> numList = new List<string>(s.Split(',')).ConvertAll<double>(x => Double.Parse(x));
                numList.Sort();
                return String.Join(",", numList);
            } catch {
                return "Please enter valid numbers";
            }
            
        }
    }
}
