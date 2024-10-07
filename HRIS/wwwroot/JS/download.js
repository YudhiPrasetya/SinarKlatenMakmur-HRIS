window.saveAsFile = function (fileName, byteBase64) {
   var link = this.document.createElement('a');
   link.download = fileName;
   link.href = "data:application/octet-stream;base64," + byteBase64;
   this.document.body.appendChild(link);
   link.click();
   this.document.body.removeChild(link);
}

function Print() {
   var content = document.getElementById('printable').innerHTML;
   var a = window.open('', '', 'height=800,width=800');
   a.document.write('<html>');
   a.document.write('<body><br/>');
   a.document.write(content);
   a.document.write('</body></html>');
   a.document.close();
   a.print();
}

function openPDFInNewTab(array) {
   var file = new Blob([array], { type: "application/pdf" });
   var fileURL = URL.createObjectURL(file);
   window.open(fileURL, '_blank');
}