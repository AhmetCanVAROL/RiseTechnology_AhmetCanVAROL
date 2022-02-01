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
        Mesajlar<T> Getir(Expression<Func<T, bool>> filtre = null);
        Mesajlar<T> Listele(Expression<Func<T, bool>> filtre = null);
        Mesajlar<T> Ekle(T ent);
        Mesajlar<T> Duzelt(T ent);
        Mesajlar<T> Sil(T ent);
    }
}
