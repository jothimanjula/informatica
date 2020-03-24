import { Component, OnInit } from '@angular/core';
import { Livemeeting} from '../../models/Livemeeting';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-meeting-list',
  templateUrl: './meeting-list.component.html',
  styleUrls: ['./meeting-list.component.css']
})
export class MeetingListComponent implements OnInit {

  constructor(private httpService: HttpClient) { }
  meetingList: Livemeeting[]; 
  ngOnInit() {
    this.httpService.get('https://localhost:44363//InformaticaAPI/GetLiveMeetingDetails').subscribe(  
      data => { this.meetingList = data as  Livemeeting[]   } );
  }

}
