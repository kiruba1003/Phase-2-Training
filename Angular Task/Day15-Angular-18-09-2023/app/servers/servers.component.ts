import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})

export class ServersComponent {
  serverId:number = 1001;
  serverStatus:string = 'offline';
   
  addNewServer:boolean=false;
  serverCreated:string="not yet";
  serverName:string ='';

  serverList=['sql','mysql'];

  // onServerNameEntry(event:Event)
  // {
  //   console.log(event);
  //    this.serverName = (<HTMLInputElement>event.target).value ;
  // }

  constructor()
  {
    setTimeout(()=>
    {
      this.addNewServer=true;
    },5000);
  }

 onServerCreation()
 {
   this.serverCreated = "Created";
   }

 getServerId()
{
  return this.serverId;
}

getServerStatus()
{
  return this.serverStatus;
}
}
