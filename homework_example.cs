// InputBox with value validation - first define validation delegate, which
// returns empty string for valid values and error message for invalid values ¹ê
InputBoxValidation validation = delegate(string val) {
  if (val == "")
    return "Value cannot be empty.";
  if (!(new Regex(@"^[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9_\-\.]+\.[a-zA-Z]{2,}$")).IsMatch(val))
    return "Email address is not valid.";
  return "";
};

string value = "info@example.com";
if (InputBox.Show("Enter your email address", "Email address:", ref value, validation) == DialogResult.OK)
{
  MessageBox.Show(value);
}
}