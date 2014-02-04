﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LinqOptimizer.CSharp;
using LinqOptimizer.Gpu.CSharp;
using LinqOptimizer.Base;
using System.Runtime.InteropServices;
using System.IO.MemoryMappedFiles;
using System.IO;
using LinqOptimizer.Gpu;

namespace LinqOptimizer.Tests
{



    public class Program
    {



        public static void Main(string[] args)
        {

            var input = Enumerable.Range(1, 10).Select(x => x).ToArray();

            //using (var context = new GpuContext())
            //{
            //    using (var buffer = context.Create(input))
            //    {
            //        var query = buffer.AsGpuQueryExpr().Select(x => x + 1);
            //        var test = context.Run(query).ToArray();
            //    }
            //}

            


            (new GpuQueryTests()).Where();

        }

        static void Measure(Action action)
        {
            var watch = new Stopwatch();
            watch.Start();
            action();
            Console.WriteLine(watch.Elapsed);
        }
    }

    
}
