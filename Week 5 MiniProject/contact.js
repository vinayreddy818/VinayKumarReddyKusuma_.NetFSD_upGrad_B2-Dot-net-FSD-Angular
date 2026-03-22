function submitQuery() {
      var name = document.getElementById("contactName").value.trim();
      var email = document.getElementById("contactEmail").value.trim();
      var desc = document.getElementById("contactDesc").value.trim();

      // Validation to Avoid NULL fields
      if (!name || !email || !desc) {
        alert("Please fill in all fields!");
        return;
      }

      // Email Checking
      if (!email.includes("@") || !email.includes(".")) {
        alert("Please enter a valid email address!");
        return;
      }

      // Success message when Form is Submitted
      alert("Contact Form  submitted successfully!");

      // Clear form
      document.getElementById("contactName").value = "";
      document.getElementById("contactEmail").value = "";
      document.getElementById("contactDesc").value = "";
    }