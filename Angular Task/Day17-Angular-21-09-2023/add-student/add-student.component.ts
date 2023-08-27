import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { StudentService } from '../Services/student.service';

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent {

  public AddStudentForm! : FormGroup;
 
  constructor(private formBuilder:FormBuilder, 
   private studentService:StudentService ) {}
 
   ngOnInit(): void {
     this.init();
   }
   
   private init() : void
   {
     this.AddStudentForm = this.formBuilder.group({
       rollno:[],
       studentame:[],
       addr:[],
       phno:[]
     });
   }
 
   public AddNewStudent():void
   {
     this.studentService.AddStudent(this.AddStudentForm.value)
     .subscribe(result =>
       {
       alert(" Student Added ");
       });
    }
  }
  
