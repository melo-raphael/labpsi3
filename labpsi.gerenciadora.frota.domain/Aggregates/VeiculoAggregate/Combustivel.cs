using labpsi.gerenciadora.frota.domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public class Combustivel : Enumeration
    {
        public static Combustivel Alcool = new Combustivel(0, "alcool");
        public static Combustivel Gasolina = new Combustivel(1, "gasolina");
        public static Combustivel Flex = new Combustivel(1, "flex");


        public Combustivel(int id, string name) : base(id, name)
        {
        }

        public static IEnumerable<Combustivel> List() =>
             new[] { Alcool, Gasolina, Flex };

        public static Combustivel FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new Exception($"Possible values for Combustivel: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static Combustivel From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new Exception($"Possible values for Combustivel: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
