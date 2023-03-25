using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

Public Class Class1
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using 

namespace controle
{ () referencis
    public class conexao
    {
        static private string servidor = "localhost";
        static private string bd = "ukrasystem";
        static private string usuario = "root";
        static private string senha = "";
        static private string StrCon = "server + servidor ++;databese=" + db + ";user id" + usuario + "passeword" + senha;
        public mySqlconecction getconexao(Strcon);
        Return conn;


    }

    public int cadastrar(string[] campos string[] valores, string SQLinsert)

    {        
int registro = 1 -;
        try

        { 
   conn = Getconexao();
conn.Open();
mysqlcomand cmd = new mysqlcomand(SQLInsert, CONN);
cmd. comandType = comandType.text
    cmd.ComandText= SQLInsert 
    for(int i =0; valores.length; i++)
{
                cmd.Parameters.AddWithValue(campos[i].valores[i]);
                
}
   registro = cmd ExecuteNonQuery();
            return registro;

    End Class
}