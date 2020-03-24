import { CreatemeetingComponent } from './createmeeting/createmeeting.component';
import { MeetingListComponent } from './meeting-list/meeting-list.component';
import { LoginComponent } from './login/login.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const appRoutes: Routes = [
  {
    path: '', pathMatch: 'full', redirectTo: 'login'
  },
  {
    path: 'login', pathMatch: 'full', component: LoginComponent
  },
  {
    path: 'meetinglist', pathMatch: 'full', component: MeetingListComponent
  },
  {
    path: 'createmeeting', pathMatch: 'full', component: CreatemeetingComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})


export class AppRoutingModule {

}
