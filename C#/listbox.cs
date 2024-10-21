


private void Form1_Load(object sender, EventArgs e)
{
    listBox1.Items.Add("Pen");
    listBox1.Items.Add("Pencil");
    listBox1.Items.Add("Book");
    listBox1.Items.Add("Eraser");
    listBox1.Items.Add("Scale");
    listBox1.Text = "";  // Clear any pre-selected text in the ListBox
    
    // Subscribe to the SelectedIndexChanged event
    listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
}

// Event handler to update the label when the selected item in the ListBox changes
private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    // Display the selected item in the label
    if (listBox1.SelectedItem != null) // Check if an item is selected
    {
        label1.Text = listBox1.SelectedItem.ToString();
    }
}
