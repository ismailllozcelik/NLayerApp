using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.UnifOfWorks
{
    public interface IUnifOfWork
    {
        Task CommitAsync();

        void Commit();
    }
}
