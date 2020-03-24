import { Component, OnInit } from '@angular/core';
import { Livemeeting} from '../../models/Livemeeting';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-createmeeting',
  templateUrl: './createmeeting.component.html',
  styleUrls: ['./createmeeting.component.css']
})
export class CreatemeetingComponent implements OnInit {

  constructor(private httpService: HttpClient) { }
  meetingList: Livemeeting[]; 
  ngOnInit() {
    this.httpService.get('https://localhost:44363//InformaticaAPI/GetLiveMeeting').subscribe(  
      data => { this.meetingList = data as  Livemeeting[]  } );
  }

}
