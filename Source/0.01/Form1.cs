using HashTableDemo.Helper;

namespace HashTableDemo
{
    public partial class Form1 : Form
    {
        public HashTable myHT = new HashTable();
        //State=-2,-1,0,1,2
        //-2 refers to both chained values and value were deleted
        //-1 refers to both value deleted
        //0 refers to it's empty
        //1 refers to have the existence of chained values
        //2 refers to don't have the existence of chained values and value filled

        public Form1()
        {
            InitializeComponent();
        }

        private void AddElementsBTN_Click(object sender, EventArgs e)
        {
            if (HashTableSizeTB.Text != null && HashTableSizeTB.Text.CompareTo("") != 0 && HashTableElementsTB.Text != null && HashTableElementsTB.Text.CompareTo("") != 0)
            {
                int HashTableSize = int.Parse(HashTableSizeTB.Text);
                if (HashTableSize > 0)
                {
                    String HashTableElementsString = HashTableElementsTB.Text;
                    String[] HashTableElementsStringArray = HashTableElementsString.Split(",");
                    if (HashTableElementsStringArray.Length != 0)
                    {
                        int Loop = 0;
                        if (myHT.myHashTableElements.Length == 0)
                        {
                            myHT.myHashTableElements = new HashTableElement[HashTableElementsStringArray.Length];
                            while (Loop < HashTableElementsStringArray.Length)
                            {
                                myHT.myHashTableElements[Loop] = new HashTableElement();
                                Loop += 1;
                            }
                            Loop = 0;
                        }                        
                        while (Loop < HashTableElementsStringArray.Length)
                        {
                            int myHashTableElement = int.Parse(HashTableElementsStringArray[Loop]);
                            int myHashTableElementIndex = 0;
                            myHashTableElementIndex = myHashTableElement % HashTableElementsStringArray.Length;
                            if (myHT.UsedIndex.Contains(myHashTableElementIndex) == true)
                            {
                                if (myHT.myHashTableElements[Loop].State == -1)
                                {
                                    myHT.myHashTableElements[myHashTableElementIndex].Value = myHT.myHashTableElements[myHashTableElementIndex].ChainedValues[0];
                                    myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Add(myHashTableElement);
                                    myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Remove(myHT.myHashTableElements[myHashTableElementIndex].ChainedValues[0]);
                                    myHT.myHashTableElements[myHashTableElementIndex].State = 1;
                                }
                                else 
                                {
                                    myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Add(myHashTableElement);
                                    myHT.myHashTableElements[myHashTableElementIndex].State = 1;
                                }
                            }
                            else
                            {
                                myHT.myHashTableElements[myHashTableElementIndex].Value = myHashTableElement;
                                myHT.UsedIndex.Add(myHashTableElementIndex);
                                myHT.myHashTableElements[myHashTableElementIndex].State = 2;
                            }
                            Loop += 1;
                        }
                    }
                }
            }
        }

        private void ReadElementsBTN_Click(object sender, EventArgs e)
        {
            int Loop = 0;
            while (Loop < myHT.myHashTableElements.Length)
            {
                if (myHT.myHashTableElements[Loop].ChainedValues.Count != 0)
                {
                    int AnotherLoop = 0;
                    String ResultString = "Chained Values:";
                    while (AnotherLoop < myHT.myHashTableElements[Loop].ChainedValues.Count)
                    {
                        ResultString += myHT.myHashTableElements[Loop].ChainedValues[AnotherLoop];
                        if (AnotherLoop + 1 != myHT.myHashTableElements[Loop].ChainedValues.Count)
                        {
                            ResultString += ",";
                        }
                        AnotherLoop += 1;
                    }
                    MessageBox.Show(ResultString);
                }
                MessageBox.Show("Value:" + myHT.myHashTableElements[Loop].Value.ToString());
                Loop += 1;
            }
        }

        private void DeleteElementsBTN_Click(object sender, EventArgs e)
        {
            if (DeleteElementsTB.Text != null && DeleteElementsTB.Text.CompareTo("") != 0)
            {
                if (myHT.myHashTableElements.Length != 0)
                {
                    String HashTableElementsString = DeleteElementsTB.Text;
                    String[] HashTableElementsStringArray = HashTableElementsString.Split(",");
                    if (HashTableElementsStringArray.Length != 0)
                    {
                        int Loop = 0;
                        while (Loop < HashTableElementsStringArray.Length)
                        {
                            int myHashTableElement = int.Parse(HashTableElementsStringArray[Loop]);
                            int myHashTableElementIndex = 0;
                            myHashTableElementIndex = myHashTableElement % HashTableElementsStringArray.Length;
                            if (myHT.UsedIndex.Contains(myHashTableElementIndex) == true)
                            {
                                if (myHT.myHashTableElements[myHashTableElementIndex].State >= 1)
                                {
                                    if (myHT.myHashTableElements[myHashTableElementIndex].Value == myHashTableElement)
                                    {
                                        myHT.myHashTableElements[myHashTableElementIndex].Value = 0;
                                        if (myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Count == 0)
                                        {
                                            myHT.myHashTableElements[myHashTableElementIndex].State = -2;
                                        }
                                        else 
                                        {
                                            myHT.myHashTableElements[myHashTableElementIndex].State = -1;
                                        }
                                    }
                                    else 
                                    {
                                        if (myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Count != 0)
                                        {
                                            if (myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Contains(myHashTableElement) == true) 
                                            {
                                                myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Remove(myHashTableElement);
                                                if (myHT.myHashTableElements[myHashTableElementIndex].ChainedValues.Count == 0) 
                                                {
                                                    myHT.myHashTableElements[myHashTableElementIndex].State = 2;
                                                }
                                            }                                            
                                        }
                                    }
                                }
                            }
                            Loop += 1;
                        }
                    }
                }
            }
        }

        private void SearchElementBTN_Click(object sender, EventArgs e)
        {
            if (myHT.myHashTableElements.Length != 0 && SearchElementTB.Text!=null && SearchElementTB.Text.CompareTo("")!=0) 
            {
                int HashTableElement = int.Parse(SearchElementTB.Text);
                int HashTableElementIndex = HashTableElement % myHT.myHashTableElements.Length;
                if (myHT.myHashTableElements[HashTableElementIndex].State >= 1)
                {
                    if (myHT.myHashTableElements[HashTableElementIndex].State == 1)
                    {
                        if (myHT.myHashTableElements[HashTableElementIndex].Value == HashTableElement)
                        {
                            MessageBox.Show("Value: " + HashTableElement.ToString() + " found in Index" + HashTableElementIndex.ToString());
                        }
                        else 
                        {
                            if (myHT.myHashTableElements[HashTableElementIndex].ChainedValues.Contains(HashTableElement) == true) 
                            {
                                MessageBox.Show("Value: " + HashTableElement.ToString() + " found in chain");
                            }
                        }
                    }
                    else 
                    {
                        if (myHT.myHashTableElements[HashTableElementIndex].Value == HashTableElement)
                        {
                            MessageBox.Show("Value: " + HashTableElement.ToString() + " found in Index" + HashTableElementIndex.ToString());
                        }
                    }
                }
                else if (myHT.myHashTableElements[HashTableElementIndex].State == 0)
                {
                    MessageBox.Show("This index has no value");
                }
                else 
                {
                    MessageBox.Show("This index has deleted the value");
                }
            }
        }
    }
}