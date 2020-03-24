import { Component, OnInit } from '@angular/core';
import { Useraccounts} from '../../models/Useraccounts';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private httpService: HttpClient) { }
  useraccounts: Useraccounts[]; 
  ngOnInit() {
    this.httpService.get('https://localhost:44363//InformaticaAPI/GetUsers').subscribe(  
      data => { this.useraccounts = data as  Useraccounts[]   } );
  }

}
