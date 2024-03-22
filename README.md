### ความเป็นมา

### วัตถุประสงค์

### โครงสร้างโปรแกรม
```mermaid
classDiagram
    GPU <|-- AMD
    GPU <|-- Nvidia
    GPU <|-- Intel
    Form1 <-- Form2
    Form1 <-- Form3
    Form1 <-- Form4
    Form2 <-- AMD
    Form3 <-- Nvidia
    Form4 <-- Intel
    class Form1{
        -Form2 form2 
        -Form3 form3 
        -Form4 form4
        -pictureBox1_Click(object sender, EventArgs e)
        -pictureBox2_Click(object sender, EventArgs e)


    }
    class Form2{
        -string userData
        -AMD amd 
        -int[] count
        -List<string> series

        -button3_Click(object sender, EventArgs e)
        -textBox1_TextChanged(object sender, EventArgs e)
        -button2_Click(object sender, EventArgs e)
        -button4_Click(object sender, EventArgs e)
    }
    class Form3{
        -Nvidia nvidia
        -int[] count
        -List<string> series

        -private void button3_Click(object sender, EventArgs e)
        -button4_Click(object sender, EventArgs e)
        -button2_Click(object sender, EventArgs e)


    }
    class Form4{
        -Intel Intel
        -int[] count
        -List<string> series
        -button3_Click(object sender, EventArgs e)
        -button4_Click(object sender, EventArgs e)
        -button2_Click(object sender, EventArgs e)

    }
    class CSV{
        -string path 
        +bool SavetoFile(string brand, List<string> series, int count, int total)

    }
    class AMD{
        +int[] price
        +string[] series
        +override int total(int[] count)
    }
    class Intel{
        +int[] price
        +string[] series
        +override int total(int[] count)
    }
    class Nvidia{
        +int[] price
        +string[] series
        +override int total(int[] count)
    }
    class GPU{
        +int[] price
        +virtual int total(int[] count)
    }
```
### ผู้พัฒนาโปรแกรม