using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interfaca in kendisi default public değildir ama metodları default olarak publictir
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
