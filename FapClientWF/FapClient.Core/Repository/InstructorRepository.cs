using FapClient.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FapClient.Core.Repository
{
    public class InstructorRepository : CoreRepository<Instructor>, IInstructorRepository
    {
        public char GetFirstLetter(string text)
        {
            char first = text.Split("").Select(s => s[0]).FirstOrDefault();
            return first;
        }

        public int? GetLastNumber(string text)
        {
            int? last = Convert.ToInt32(Regex.Match(text, @"\d+").Value);
            if (last == null)
            {
                return 1;
            }
            return last + 1;
        }
    }
}
