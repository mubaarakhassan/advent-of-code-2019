﻿using System;
using System.Linq;

var lines = System.IO.File.ReadAllLines(@"Input\day1.txt");
var input = lines.Select(x => int.Parse(x)).ToList();

foreach (var item in input)
{
    var difference = 2020 - item;

    if (input.Contains(difference))
    {
        var answer = item * difference;
        Console.WriteLine($"part one: {item} * {difference} = {answer}");

        break;
    }
}

foreach (var item in input)
{
    foreach (var subitem in input)
    {
        var difference = 2020 - (item + subitem);

        if (input.Contains(difference))
        {
            var answer = (item * difference) * subitem;
            Console.WriteLine($"part two: ({item} * {difference}) * {subitem} = {answer}");

            // You can break the nested loop here if you want.
        }
    }
}

