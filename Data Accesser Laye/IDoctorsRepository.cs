using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Accesser_Laye
{
    interface  IDoctorsRepository
    {
         void Insert(Doctors IN);
        void Update(long No, Doctors Replace);
        Doctors GetAll();
        Doctors GetByID();
        Doctors Delete(long no);

    }
}
