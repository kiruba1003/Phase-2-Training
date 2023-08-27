import { Component } from '@angular/core';
import { StudentService } from '../Services/student.service';

@Component({
  selector: 'app-update-student',
  templateUrl: './update-student.component.html',
  styleUrls: ['./update-student.component.css']
})
export class UpdateStudentComponent {

  student:any = {studentame :'', addr: '', phno : ''};
  
  rollno!:number;

  constructor(private studentService: StudentService,
    ) { }

  ngOnInit(): void {
  }

  public UpdateStudentById(){
      return this.studentService.UpdateStudent(this.rollno ,this.student)
      .subscribe( result =>
        {
          alert(" Student Updated ");
        }
        );
    
  }

}
