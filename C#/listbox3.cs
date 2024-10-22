private void Form1_Load(object sender, EventArgs e)
{
    // Set the SelectionMode to allow multiple selections
    listBox1.SelectionMode = SelectionMode.MultiExtended;

    // Add items to the ListBox
    listBox1.Items.Add("Pen");
    listBox1.Items.Add("Pencil");
    listBox1.Items.Add("Book");
    listBox1.Items.Add("Eraser");
    listBox1.Items.Add("Scale");

    listBox1.Text = "";  // Clear any initial text selection

    // Subscribe to the SelectedIndexChanged event
    listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
}

private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    // Initialize a string to hold the selected items
    string selectedItems = "";

    // Iterate through the selected items
    foreach (var item in listBox1.SelectedItems)
    {
        selectedItems += item.ToString() + ", ";  // Append each selected item
    }

    // Remove the trailing comma and space, if any
    if (selectedItems.Length > 0)
    {
        selectedItems = selectedItems.Substring(0, selectedItems.Length - 2);
    }

    // Display the selected items in the label
    label1.Text = selectedItems;
}
