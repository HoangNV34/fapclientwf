using FapClient.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FapClient.Core.Repository
{
    public class InstructorRepository : CoreRepository<Instructor>, IInstructorRepository
    {
        public List<Instructor> GetAll()
        {
            var list = _context.Instructors.ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].FullName.Equals(list[i + 1].FullName))
                {
                    list[i].ShortName = list[i].InstructorFirstName
                                + GetFirstLetter(list[i].InstructorLastName.ToUpper())
                                + GetFirstLetter(list[i].InstructorMidName.ToUpper()) + GetLastNumber(list[i].ShortName);
                }
                else
                {
                    list[i].ShortName = list[i].InstructorFirstName
                                + GetFirstLetter(list[i].InstructorLastName.ToUpper())
                                + GetFirstLetter(list[i].InstructorMidName.ToUpper());
                }
            }
            return list;
        }

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
