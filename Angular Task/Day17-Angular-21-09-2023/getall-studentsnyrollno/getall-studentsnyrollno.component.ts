import { Component } from '@angular/core';
import { StudentService } from '../Services/student.service';

@Component({
  selector: 'app-getall-studentsnyrollno',
  templateUrl: './getall-studentsnyrollno.component.html',
  styleUrls: ['./getall-studentsnyrollno.component.css']
})
export class GetallStudentsnyrollnoComponent {
  public student: any;
  id!:number;

  constructor(private studentService: StudentService,
    ) { }

  ngOnInit(): void {
  }
  
  public GetStudentById(){
      return this.studentService.getStudentById(this.id)
      .subscribe(result => this.student = result );
    
  }
}
