using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Common
{
    public class Result<T> //Bu class Generic Type'ta yani bu Tye ne koyarsam o gelcek
    {
        //Helper Class: Belirli task lar altında nalamlı hale gelen class lar , helper class da denir.
        public string UserMessage { get; set; }
        public bool IsSucceeded { get; set; }
        public T ProcessResult { get; set; } //Bu T yi kullanırken istediğimi atarım. Örnegin Category çekiyorum o zaman T yerine Category yerleşecek.
    }
}
