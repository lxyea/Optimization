﻿using Bss.Optimization.Sudoku.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.Optimization.Sudoku.Extensions;

namespace Bss.Optimization.Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Bss.Optimization.Sudoku.GoogleCp.Model();

            var hints = new List<GridCell>();
            hints.AddHint(1, 0, 4);
            hints.AddHint(4, 0, 6);
            hints.AddHint(7, 0, 1);
            hints.AddHint(0, 1, 7);
            hints.AddHint(3, 1, 5);
            hints.AddHint(5, 1, 3);
            hints.AddHint(8, 1, 2);
            hints.AddHint(2, 2, 3);
            hints.AddHint(4, 2, 2);
            hints.AddHint(6, 2, 7);

            hints.AddHint(1, 3, 9);
            hints.AddHint(4, 3, 7);
            hints.AddHint(7, 3, 5);
            hints.AddHint(0, 4, 1);
            hints.AddHint(2, 4, 2);
            hints.AddHint(3, 4, 8);
            hints.AddHint(5, 4, 6);
            hints.AddHint(6, 4, 4);
            hints.AddHint(8, 4, 3);
            hints.AddHint(1, 5, 6);
            hints.AddHint(4, 5, 3);
            hints.AddHint(7, 5, 2);

            hints.AddHint(2, 6, 4);
            hints.AddHint(4, 6, 1);
            hints.AddHint(6, 6, 6);
            hints.AddHint(0, 7, 6);
            hints.AddHint(3, 7, 7);
            hints.AddHint(5, 7, 2);
            hints.AddHint(8, 7, 1);
            hints.AddHint(1, 8, 7);
            hints.AddHint(4, 8, 5);
            hints.AddHint(7, 8, 3);

            var results = model.Solve(hints);

            // Display results
            Console.WriteLine($"Number of valid solutions: {results.Count()}");
            foreach (var result in results)
            {
                Console.WriteLine(result.GetDisplay());
                Console.WriteLine("");
            }
        }
    }
}
