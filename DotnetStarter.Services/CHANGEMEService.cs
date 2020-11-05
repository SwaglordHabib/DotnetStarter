using System;
using DotnetStarter.Models;

namespace DotnetStarter.Services
{
    public interface ICHANGEMEService
    {
        /*
         *
         *
         * Hier werden die Methoden für den Service definiert.
         * void AddCHANGEME(CHANGEME changeme);
         * string GerCHANGEMEById(int id);
         * und so weiter....
         *
         */
        void AddCHANGEME(CHANGEME changeme);
    }

    public class CHANGEMEService : ICHANGEMEService
    {
        /*
         *
         *
         * Hier kommen Methoden die Logik enthalten rein.
         * Berechnungen, Switch case, Datenbank aufrufe.
         *
         *
         */
        public void AddCHANGEME(CHANGEME changeme)
        {
            throw new NotImplementedException();
        }
    }
}
