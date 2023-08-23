import { Component } from '@angular/core';

@Component({
  selector: 'app-bindingusername',
  templateUrl: './bindingusername.component.html',
  styleUrls: ['./bindingusername.component.css']
})
export class BindingusernameComponent {

  username :string='';
  showusername:string='';

  onClick(){
    this.showusername = this.username;

  }
}
