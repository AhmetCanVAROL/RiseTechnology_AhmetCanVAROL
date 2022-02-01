using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RiseTechnology.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using TPIC.Entities.General;

namespace TPIC.Dal.Concrete
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class
        where TContext : DbContext,new()
    {
        public Mesajlar<TEntity> Duzelt(TEntity ent)
        {
            Mesajlar<TEntity> m = new Mesajlar<TEntity>();

            try
            {
                PropertyInfo Is_Tarih = ent.GetType().GetProperty("DuzeltmeTarih");
                if (Is_Tarih != null)
                    Is_Tarih.SetValue(ent, DateTime.Now);

           
                PropertyInfo Durum = ent.GetType().GetProperty("Durum");
                if (Durum != null)
                    Durum.SetValue(ent, true);


                using (var cnt = new TContext())
                {
                    EntityEntry<TEntity> addEntity = cnt.Entry(ent);
                    //addEntity.State = EntityState.Modified;

                    IEnumerable<PropertyEntry> lst = cnt.Entry(ent).Properties;

                    string pKey = PrimaryKey_Name(addEntity);

                    foreach (var i in lst)
                    {
                        if (i.CurrentValue != null && i.Metadata.Name != pKey)
                        {
                            i.IsModified = true;
                        }
                    }

                    cnt.SaveChanges();

                    m.Nesne = addEntity.Entity;

                }

                 m.Durum = true;
                m.Mesaj = "Kayıt güncellendi.";
            }
            catch (Exception ex)
            {
                
                m.Durum = false;
                m.Mesaj = "Kayıt Güncellenemedi. Bilgileri Kontrol Ediniz.";
            }

            return m;
        }

        public Mesajlar<TEntity> Ekle(TEntity ent)
        {
            Mesajlar<TEntity> m = new Mesajlar<TEntity>();

            try
            {
                PropertyInfo Is_Tarih = ent.GetType().GetProperty("KayitTarih");
                if (Is_Tarih != null)
                    Is_Tarih.SetValue(ent, DateTime.Now);

                PropertyInfo Durum = ent.GetType().GetProperty("Durum");
                if (Durum != null)
                    Durum.SetValue(ent, true);

                using (var cnt = new TContext())
                {
                    var addEntity = cnt.Entry(ent);
                    addEntity.State = EntityState.Added;
                    cnt.SaveChanges();

                    m.Nesne = addEntity.Entity;

                }

                m.Durum = true; 
                m.Mesaj = "Kayıt eklendi.";
            }
            catch (Exception ex)
            {
                m.Durum = false;
                m.Mesaj = "Kayıt Eklenemedi. Bilgileri Kontrol Ediniz.";
            }
                     

            return m;
        }
       
        public Mesajlar<TEntity> Getir(Expression<Func<TEntity, bool>> filtre = null)
        {
            Mesajlar<TEntity> m = new Mesajlar<TEntity>();

            try
            {
                using (var cnt = new TContext())
                {
                    var ns = cnt.Set<TEntity>();

                    m.Nesne = ns.FirstOrDefault(filtre);
                }

                 m.Durum = true;
                m.Mesaj = "Kayıt görüntülendi.";

            }
            catch (Exception ex)
            {
                m.Durum = false;
                m.Mesaj = ex.Message + " " + ex.StackTrace;

            }
            return m;
        }

        public Mesajlar<TEntity> Sil(TEntity ent)
        {
            Mesajlar<TEntity> m = new Mesajlar<TEntity>();

            try
            {
                PropertyInfo Is_Tarih = ent.GetType().GetProperty("SilmeTarih");
                if (Is_Tarih != null)
                    Is_Tarih.SetValue(ent, DateTime.Now);

                PropertyInfo Durum = ent.GetType().GetProperty("Durum");
                if (Durum != null)
                    Durum.SetValue(ent, false);


                using (var cnt = new TContext())
                {
                    var addEntity = cnt.Entry(ent);
                    addEntity.State = EntityState.Modified;
                    cnt.SaveChanges();

                    m.Nesne = addEntity.Entity;
                }

                m.Durum = true; 
                m.Mesaj = "Kayıt bilgileri silindi.";
            }
            catch (Exception ex)
            {
                m.Durum = false;
                m.Mesaj = ex.Message + Environment.NewLine + ex.StackTrace;
            }

         

            return m;
        }

        public Mesajlar<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null)
        {
            Mesajlar<TEntity> m = new Mesajlar<TEntity>();

            try
            {
                using (var cnt = new TContext())
                {
                    var ns = cnt.Set<TEntity>();

                    if (filtre == null)
                        m.Liste = ns.ToList();
                    else
                        m.Liste = ns.Where(filtre).ToList();

                    if (m.Liste == null) m.Liste = new List<TEntity>();

                }

                m.Durum = true;
                m.Mesaj = "Kayıt listelendi.";
            }
            catch (Exception ex)
            {
                m.Durum = false;
                m.Mesaj = ex.Message + " " + ex.StackTrace;
            }

            return m;
        }         

        public string PrimaryKey_Name(EntityEntry<TEntity> _entry)
        {
            var idName = _entry.Metadata.FindPrimaryKey().Properties.Select(x => x.Name).Single();
            return idName;
        }
       
    }
}
