using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Country
    {
        private List<KeyValuePair<State, double>> listStates;


        public Country()
        {
            this.listStates = new List<KeyValuePair<State, double>>();
            this.LoadStates();
        }


        public State[] Top10StatesByArea()
        {
            return this.listStates.Select(st => new { State = st.Key, Area = st.Value})
                                  .OrderByDescending(i => i.Area).Take(10)
                                  .Select(obj => obj.State).ToArray<State>();
        }


        private void LoadStates()
        {
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"AC", name:"Acre"), 164123.040));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"AL", name:"Alagoas"), 27778.506));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"AP", name:"Amapa"), 142828.521));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"AM", name:"Amazonas"), 1559159.148));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"BA", name:"Bahia"), 564733.177));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"CE", name:"Ceara"), 148920.472));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"DF", name:"Distrito Federal"), 5779.999));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"ES", name:"Espirito Santo"), 46095.583));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"GO", name:"Goias"), 340111.783));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"MA", name:"Maranhao"), 331937.450));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"MT", name:"Mato Grosso"), 903366.192));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"MS", name:"Mato Grosso do Sul"), 357145.532));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"MG", name:"Minas Gerais"), 586522.122));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"PA", name:"Para"), 1247954.666));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"PB", name:"Paraiba"), 56585.000));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"PR", name:"Parana"), 199307.922));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"PE", name:"Pernambuco"), 98311.616));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"PI", name:"Piaui"), 251577.738));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"RJ", name:"Rio de Janeiro"), 43780.172));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"RN", name:"Rio Grande do Norte"), 52811.047));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"RS", name:"Rio Grande do Sul"), 281730.223));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"RO", name:"Rondonia"), 237590.547));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"RR", name:"Roraima"), 224300.506));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"SC", name:"Santa Catarina"), 95736.165));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"SP", name:"Sao Paulo"), 248222.362));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"SE", name:"Sergipe"), 21915.116));
            this.listStates.Add(new KeyValuePair<State, double>(new State(acronym:"TO", name:"Tocantins"), 277720.520));
        }
    }
}
