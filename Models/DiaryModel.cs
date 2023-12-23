using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Models{

    public class DiaryModel{
        public Guid Id { get; set; } = Guid.NewGuid();
        public string DiaryData { get; set; } = "";
        public DateTime PostStamp {get; set;} = DateTime.Now;
    }
}