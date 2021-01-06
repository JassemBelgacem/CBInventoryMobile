using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace InventoryCB.Business.Technical
{
    /*
     * W : le type du DTO webService
     * B : Le type du bean de l'application
     * 
     * */
    abstract class CbnMapper<W, B>
    {
        public abstract B wsDtoToBean(W wsDto);

        public abstract W beanToWsDto(B bean);

        public List<B> wsDtoListToListBean(W[] wsBeanList)
        {
            List<B> list = new List<B>();
            if (wsBeanList != null)
            {
                foreach (W item in wsBeanList)
                {
                    list.Add(wsDtoToBean(item));
                }
            }

            return list;
        }

        public List<W> wsBeanListToListDto(B[] wsDtoList)
        {
            List<W> list = new List<W>();
            if (wsDtoList != null)
            {
                foreach (B item in wsDtoList)
                {
                    list.Add(beanToWsDto(item));
                }
            }

            return list;
        }
    }
}
