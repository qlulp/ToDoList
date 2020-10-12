using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Classes
{
    class DataManager
    {
        public static void Serialize(List<Task> tasks, bool showMessage = false)
        {
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, tasks);
                if (showMessage)
                    MessageBox.Show("Данные сохранены");
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Ошибка при сериализации. Причина: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static List<Task> Deserialize()
        {
            // Declare the hashtable reference.
            List<Task> tasks;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream("DataFile.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and
                // assign the reference to the local variable.
                tasks = (List<Task>)formatter.Deserialize(fs);
                return tasks;
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Ошибка при десериализации. Причина: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static int GetCountOfSelectedItems(in List<Task> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item.IsSelected)
                    count++;
            }
            return count;
        }

        public static int GetCountOfDoneItems(in List<Task> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item.IsDone)
                    count++;
            }
            return count;
        }

        public static int GetCountOfItems(in List<Task> items)
        {
            return items.Count;
        }

        public static int GetCountOfNotDoneItems(in List<Task> items)
        {
            return items.Count - GetCountOfDoneItems(items);
        }
    }
}
