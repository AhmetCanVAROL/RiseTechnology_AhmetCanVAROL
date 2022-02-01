using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TPIC.Entities.General;

namespace RiseTechnology.DAL.Abstract
{
    public interface IEntityRepository<T> where T:class
    {
        Mesajlar<T> Getir(int KulID, Expression<Func<T, bool>> filtre = null);
        Mesajlar<T> Listele(int KulID, Expression<Func<T, bool>> filtre = null);
        Mesajlar<T> Ekle(T ent, int KulID);
        Mesajlar<T> Duzelt(T ent, int KulID);
        Mesajlar<T> Sil(T ent, int KulID);
    }
}
