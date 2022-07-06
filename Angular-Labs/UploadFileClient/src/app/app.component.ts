import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'UploadFileClient';

  /**
   *
   */
  constructor(private http:HttpClient) {
   

  }
  
  uploadFile=(files)=>{
    console.log("Hi");
    
    if(files.length==0){
      return;
    }
    let filetoUpload=<File>files[0];
    const formData=new FormData();
    formData.append('file',filetoUpload,filetoUpload.name)
    this.http.post("https://localhost:44308/api/upload",formData).subscribe(res=>console.log(res),res=>console.log(res));
  }
}
