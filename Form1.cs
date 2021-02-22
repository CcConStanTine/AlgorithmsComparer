using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Projekt_v2._0
{
    public partial class Form1 : Form
    {
        List<int> indexes;
        List<int> dataSet;
        Stopwatch stopwatch1 = new Stopwatch();
        Stopwatch stopwatch2 = new Stopwatch();
        List<ManualResetEvent> listOfSyncEvents;

        public Form1()
        {
            InitializeComponent();

            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sortUsingMultithreading();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread newThread = new Thread(() =>
            {
                foreach(ManualResetEvent syncEvent in listOfSyncEvents)
                {
                    syncEvent.WaitOne();
                }
                stopwatch1.Stop();
                MessageBox.Show("Multithreaded sorting took: " + stopwatch2.ElapsedMilliseconds + " milliseconds. ");
            });
            newThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indexes = new List<int>();
            foreach (int index in checkBox_algorithms.CheckedIndices)
            {
                indexes.Add(index);
            }
            if (indexes.Capacity == 0)
                MessageBox.Show("Choose at least one algorithm!");
            else if (comboBox_dataSetSize.SelectedItem == null)
                MessageBox.Show("Select data set size!");
            else if (comboBox_dataSetSize.SelectedItem == null)
                MessageBox.Show("Select data pattern!");
            else if (!checkBox_Multithreaded.Checked)
            {
                stopwatch1.Reset();
                stopwatch1.Start();
                sortWithoutUsingMultithreading();
                stopwatch1.Stop();
                MessageBox.Show("Non-multithreaded soring took: " + stopwatch1.ElapsedMilliseconds + " milliseconds. ");
            }
            else
            {
                stopwatch2.Reset();
                stopwatch2.Start();
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void sortUsingMultithreading()
        {
            listOfSyncEvents  = new List<ManualResetEvent>(6);
            for (int i=0; i<6; i++)
            {
                listOfSyncEvents.Add(new ManualResetEvent(true));
            }
            if (indexes.Contains(0))
             {
                listOfSyncEvents[0] = new ManualResetEvent(false);
                List<int> sortedDataSet = new List<int>(dataSet);
                Thread newThread = new Thread(() => {
                    selectionSort(sortedDataSet);
                    listOfSyncEvents[0].Set();
                });
                newThread.Start();
            }
            if (indexes.Contains(1))
            {
                listOfSyncEvents[1] = new ManualResetEvent(false);
                List<int> sortedDataSet = new List<int>(dataSet);
                Thread newThread = new Thread(() => {
                    bubbleSort(sortedDataSet);
                    listOfSyncEvents[1].Set();
                });
                newThread.Start();

            }
            if (indexes.Contains(2))
            {
                listOfSyncEvents[2] = new ManualResetEvent(false);
                List<int> sortedDataSet = new List<int>(dataSet);
                Thread newThread = new Thread(() => {
                    insertionSort(sortedDataSet);
                    listOfSyncEvents[2].Set();
                });
                newThread.Start();
            }
            if (indexes.Contains(3))
            {
                listOfSyncEvents[3] = new ManualResetEvent(false);
                List<int> sortedDataSet = new List<int>(dataSet);
                Thread newThread = new Thread(() => {
                    mergeSort(sortedDataSet, 0, sortedDataSet.Capacity - 1);
                    listOfSyncEvents[3].Set();
                });
                newThread.Start();
            }
            if (indexes.Contains(4))
            {
                listOfSyncEvents[4] = new ManualResetEvent(false);
                List<int> sortedDataSet = new List<int>(dataSet);
                Thread newThread = new Thread(() => {
                    quickSort(sortedDataSet, 0, sortedDataSet.Capacity - 1);
                    listOfSyncEvents[4].Set();
                });
                newThread.Start();
            }
            if (indexes.Contains(5))
            {
                listOfSyncEvents[5] = new ManualResetEvent(false);
                List<int> sortedDataSet = new List<int>(dataSet);
                Thread newThread = new Thread(() => {
                    heapSort(sortedDataSet, sortedDataSet.Capacity - 1);
                    listOfSyncEvents[5].Set();
                });
                newThread.Start();
            }
        }
        private void sortWithoutUsingMultithreading()
        {
            if (indexes.Contains(0))
            {
                List<int> sortedDataSet = new List<int>(dataSet);
                selectionSort(sortedDataSet);
            }
            if (indexes.Contains(1))
            {
                List<int> sortedDataSet = new List<int>(dataSet);
                bubbleSort(sortedDataSet);
            }
            if (indexes.Contains(2))
            {
                List<int> sortedDataSet = new List<int>(dataSet);
                insertionSort(sortedDataSet);
            }
            if (indexes.Contains(3))
            {
                List<int> sortedDataSet = new List<int>(dataSet);
                mergeSort(sortedDataSet, 0, sortedDataSet.Capacity - 1);
            }
            if (indexes.Contains(4))
            {
                List<int> sortedDataSet = new List<int>(dataSet);
                quickSort(sortedDataSet, 0, sortedDataSet.Capacity - 1);
            }
            if (indexes.Contains(5))
            {
                List<int> sortedDataSet = new List<int>(dataSet);
                heapSort(sortedDataSet, sortedDataSet.Capacity - 1);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_dataPattern.SelectedItem != null)
            {
                int dataPattern = comboBox_dataPattern.SelectedIndex;
                int selectedDataSetSize = Convert.ToInt32(comboBox_dataSetSize.SelectedItem);
                dataSet = new List<int>(selectedDataSetSize);
                Thread newThread = new Thread(() => fillListWithData(dataPattern, selectedDataSetSize));
                newThread.Start();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_dataSetSize.SelectedItem != null)
            {
                int dataPattern = comboBox_dataPattern.SelectedIndex;
                int selectedDataSetSize = Convert.ToInt32(comboBox_dataSetSize.SelectedItem);
                dataSet = new List<int>(selectedDataSetSize);
                Thread newThread = new Thread(() => fillListWithData(dataPattern, selectedDataSetSize));
                newThread.Start();
            }
        }
        private void fillListWithData(int dataPattern, int selectedDataSetSize)
        {
            switch(dataPattern)
            {
                case 0:
                    {
                        for (int i = 0; i < selectedDataSetSize; i++)
                        {
                            dataSet.Add(i);
                        }
                    } break;
                case 1:
                    {
                        for (int i = selectedDataSetSize-1; i >= 0; i--)
                        {
                            dataSet.Add(i);
                        }
                    }
                    break;
                case 2:
                    {
                        Random random = new Random();
                        for (int i = 0; i < selectedDataSetSize; i++)
                        {
                            dataSet.Add(random.Next(0, selectedDataSetSize));
                        }
                    }
                    break;
            }
        }
        private void selectionSort(List<int> list)
        {
            int temp, smallest;
            for (int i = 0; i < list.Capacity - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < list.Capacity; j++)
                {
                    if (list[j] < list[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = list[smallest];
                list[smallest] = list[i];
                list[i] = temp;
            }
        }
        private void bubbleSort(List<int> list)
        {
            int temp;
            for (int j = 0; j <= list.Capacity - 2; j++)
            {
                for (int i = 0; i <= list.Capacity - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
        }
        private void insertionSort(List<int> list)
        {
            int i, j, val, flag;
            for (i = 1; i < list.Capacity; i++)
            {
                val = list[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
        }
        private void mergeSort(List<int> list, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(list, p, q);
                mergeSort(list, q + 1, r);
                merge(list, p, q, r);
            }
        }
        static public void merge(List<int> list, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = list[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = list[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    list[k] = L[i];
                    i++;
                }
                else
                {
                    list[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                list[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                list[k] = R[j];
                j++;
                k++;
            }
        }
        private void quickSort(List<int> list, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = partition(list, start, end);

                quickSort(list, start, i - 1);
                quickSort(list, i + 1, end);
            }
        }
        private int partition(List<int> list, int start, int end)
        {
            int temp;
            int p = list[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (list[j] <= p)
                {
                    i++;
                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            temp = list[i + 1];
            list[i + 1] = list[end];
            list[end] = temp;
            return i + 1;
        }
        private void heapSort(List<int> list, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(list, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = list[0];
                list[0] = list[i];
                list[i] = temp;
                heapify(list, i, 0);
            }
        }
        private void heapify(List<int> list, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && list[left] > list[largest])
                largest = left;
            if (right < n && list[right] > list[largest])
                largest = right;
            if (largest != i)
            {
                int swap = list[i];
                list[i] = list[largest];
                list[largest] = swap;
                heapify(list, n, largest);
            }
        }

    }
}
