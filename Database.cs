using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace DTR_calculator
{
    public static class Database
    {
        private static string connectionString = "Data Source=dtr.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void Initialize()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string employeeTable = @"
                   CREATE TABLE IF NOT EXISTS Employees (
                        EmployeeId INTEGER PRIMARY KEY AUTOINCREMENT,
                        EmployeeNo TEXT NOT NULL,
                        FullName TEXT NOT NULL); ";

                string scheduleTable = @"
                    CREATE TABLE IF NOT EXISTS WorkSchedules (
                        ScheduleId INTEGER PRIMARY KEY AUTOINCREMENT,
                        ScheduleName TEXT,
                        TimeIn TEXT,
                        TimeOut TEXT,
                        BreakStart TEXT,
                        BreakEnd TEXT
                        RequiredHours REAL
                        );";

                string dtrTable = @"
                    CREATE TABLE IF NOT EXISTS DTR (
                        DTRId INTEGER PRIMARY KEY AUTOINCREMENT,
                        EmployeeId INTEGER,
                        WorkDate TEXT,

                       TimeIn1 TEXT,
                       TimeOut1 TEXT,
                       TimeIn2 TEXT,
                       TimeOut2 TEXT,

                        RenderedHours REAL,
                        LateHours REAL,
                        UndertimeHours REAL,
                        OvertimeHours REAL,

                        FOREIGN KEY(EmployeeId) REFERENCES Employees(EmployeeId)
                    );";

                ExecuteCommand(conn, employeeTable);
                ExecuteCommand(conn, scheduleTable);
                ExecuteCommand(conn, dtrTable);


            }
        }

        private static void ExecuteCommand(SQLiteConnection conn, string sql)
        {
            using (var cmd = new SQLiteCommand(sql, conn))
                    {
                cmd.ExecuteNonQuery();
            }
        }

    }
}
