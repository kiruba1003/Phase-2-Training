import { Component } from '@angular/core';
import { StudentService } from '../Services/student.service';

@Component({
  selector: 'app-getall-students',
  templateUrl: './getall-students.component.html',
  styleUrls: ['./getall-students.component.css']
})
export class GetallStudentsComponent {

  public students: any;
  constructor(private service: StudentService) { }

  ngOnInit(): void {
    this.getStudents();
  }

  public getStudents(): void 
  {
    this.service.getAllStudents().subscribe(result => {
      this.students = result;
      //console.log(this.students);
    });
  }

}
