using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın Standartı
    //Bir class herhangi bir inheritance implementasyonu almıyorsa ilerde sorun yaşayacaksın!!
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
