﻿using Metro_Asset_System.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Handler
{
    public class Generator
    {
        private static readonly Random random = new Random((int)DateTime.Now.Ticks);

        public string RandomNumber(int num1, int num2)
        {
            var id = random.Next(num1, num2);
            return id.ToString();
        }
        public string GenerateGuid() 
        {
            Guid obj = Guid.NewGuid();
            return obj.ToString();
        }

        public string GenerateRequestId(int num) 
        {
            int next = num + 1;
            return "RQT" + DateTime.Now.ToString("yy") + next;
        }

        public string GenerateInvoiceId(int num) 
        {
            int next = num + 1;
            return "INV" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy") + next;
        }
        public string GenerateAssetId(int num)
        {
            int next = num + 1;
            return DateTime.Now.ToString("yy") + next;
        }

        public string GenerateDepartmentId(int num)
        {
            int next = num + 1;
            return DateTime.Now.ToString("yy") + next;
        }
    }
}
