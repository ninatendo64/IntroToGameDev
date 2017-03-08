using UnityEngine;
using System.Collections;

public class HomeScreenManager : MonoBehaviour { 
	//creating public game objects and booleans 
	// making the gameobjects public allows them to be accessed outside of the script
	// public bool ____showing = false means that that screen is by default not showing.

	public GameObject CalendarObject;
	public bool CalendarShowing = false;

	public GameObject PhotosObject;
	public bool PhotosShowing = false;

	public GameObject MessagesObject;
	public bool MessagesShowing = false;

	public GameObject CameraObject;
	public bool CameraShowing = false;

	public GameObject WeatherObject;
	public bool WeatherShowing = false;

	public GameObject AlarmObject;
	public bool AlarmShowing = false;

	public GameObject RemindersObject;
	public bool RemindersShowing = false;

	public GameObject MapsObject;
	public bool MapsShowing = false;

	public GameObject HealthObject;
	public bool HealthShowing = false;

	public GameObject ContactsObject;
	public bool ContactsShowing = false;

	public GameObject MailObject;
	public bool MailShowing = false;

	public GameObject NewsObject;
	public bool NewsShowing = false;

	public GameObject YouTubeObject;
	public bool YouTubeShowing = false;

	public GameObject NotesObject;
	public bool NotesShowing = false;

	public GameObject SnapChatObject;
	public bool SnapChatShowing = false;

	public GameObject BankObject;
	public bool BankShowing = false;

	public GameObject TwitterObject;
	public bool TwitterShowing = false;

	public GameObject InstagramObject;
	public bool InstagramShowing = false;

	public GameObject TumblrObject;
	public bool TumblrShowing = false;

	public GameObject TinderObject;
	public bool TinderShowing = false;

	public GameObject NekoAtsumeObject;
	public bool NekoAtsumeShowing = false;

	public GameObject PhoneObject;
	public bool PhoneShowing = false;

	public GameObject SafariObject;
	public bool SafariShowing = false;

	public GameObject SpotifyObject;
	public bool SpotifyShowing = false;

	public GameObject HomeScreenObject;
	public bool HomeScreenShowing = false;

	public GameObject StartScreenObject; //game still open with a start screen.
	public bool StartScreenShowing = true;

	//messages second layer stuff

	public GameObject Convo1Object; //conversation 1 
	public bool Convo1Showing = false;

	public GameObject Convo2Object; //conversation 2
	public bool Convo2Showing = false;

	public GameObject Convo3Object; //conversation 3
	public bool Convo3Showing = false;

	public GameObject Convo4Object; //conversation 4
	public bool Convo4Showing = false;

	public GameObject Convo5Object; //conversation 5
	public bool Convo5Showing = false;

	//notes second layer stuff
	public GameObject Note1Object; //Note 1 
	public bool Note1Showing = false;

	public GameObject Note2Object; //Note 2
	public bool Note2Showing = false;

	public GameObject Note3Object; //Note 3
	public bool Note3Showing = false;

	public GameObject Note4Object; //Note 4
	public bool Note4Showing = false;

	public GameObject Note5Object; //Note 5
	public bool Note5Showing = false;

	//news second layer stuff
	public GameObject News1Object; //News 1 
	public bool News1Showing = false;

	public GameObject News2Object; //News 2
	public bool News2Showing = false;

	public GameObject News3Object; //News 3
	public bool News3Showing = false;

	public GameObject News4Object; //News 4
	public bool News4Showing = false;

	public GameObject News5Object; //News 5
	public bool News5Showing = false;

	//safari second layer stuff
	public GameObject Tab1Object; //Tab 1 
	public bool Tab1Showing = false;

	public GameObject Tab2Object; //Tab 2 
	public bool Tab2Showing = false;

	public GameObject Tab3Object; //Tab 3
	public bool Tab3Showing = false;

	public GameObject Tab4Object; //Tab 4
	public bool Tab4Showing = false;

	public GameObject Tab5Object; //Tab 5
	public bool Tab5Showing = false;

	public GameObject HistoryObject; //history
	public bool HistoryShowing = false;

	//spotify second layer stuff
	public GameObject Playlist1Object; //Playlist 1 
	public bool Playlist1Showing = false;

	public GameObject Playlist2Object; //Playlist 2
	public bool Playlist2Showing = false;

	public GameObject Playlist3Object; //Playlist 3
	public bool Playlist3Showing = false;

	public GameObject Playlist4Object; //Playlist 4
	public bool Playlist4Showing = false;

	public GameObject Playlist5Object; //Playlist 5
	public bool Playlist5Showing = false;

	public GameObject NowPlayingObject; //nowplaying
	public bool NowPlayingShowing = false;

	//tinder second layer stuff
	public GameObject Match1Object; //Match 1 
	public bool Match1Showing = false;

	public GameObject Match2Object; //Match 2
	public bool Match2Showing = false;

	public GameObject Match3Object; //Match 3
	public bool Match3Showing = false;

	public GameObject Match4Object; //Match 4
	public bool Match4Showing = false;

	public GameObject Match5Object; //Match 5
	public bool Match5Showing = false;

	public GameObject FrontFacingCameraObject; //front facing camera screen ?
	public bool FrontFacingCameraShowing = false;

	//second layer phone stuff

	public GameObject VoicemailObject; //voicemail screen
	public bool VoicemailShowing = false;

	public GameObject KeypadObject; //keypad screen
	public bool KeypadShowing = false;






	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	




		//clicking the home button!!! this is really important !!




	}
	public void HomeClick (){ //home button functions

		//first layer -- will bring directly back to homescreen

		if (StartScreenShowing ==true) { //close the start screen to begin the game
			StartScreenShowing = false;
			StartScreenObject.SetActive (false); //start screen is no longer active
			HomeScreenShowing =true; //home screen will appear
			HomeScreenObject.SetActive (true); //home screen is active
		}

		if (CalendarShowing == true) { //if the calendar is showing, make it disappear
			CalendarShowing = false;
			CalendarObject.SetActive (false); //calendar is no longer active 
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active
				}


		if (PhotosShowing == true) { //if the photos screen is showing, make it disappear
			PhotosShowing = false;
			PhotosObject.SetActive (false); //photos is no longer active
			HomeScreenShowing = true; //make the home screen show
			HomeScreenObject.SetActive (true); //make the home screen active
				}


		if (MessagesShowing == true) { //if the messages screen is showing, make it disappear
			MessagesShowing = false;
			MessagesObject.SetActive (false); //messages is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (CameraShowing == true) { //if the camera screen is showing, make it disappear
			CameraShowing = false;
			CameraObject.SetActive (false); //camera is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (WeatherShowing == true) { //if the weather screen is showing, make it disappear
			WeatherShowing = false;
			WeatherObject.SetActive (false); //weather is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (AlarmShowing == true) { //if the alarm screen is showing, make it disappear
			AlarmShowing = false; 
			AlarmObject.SetActive (false); //alarm is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (RemindersShowing == true) { //if the Reminders screen is showing, make it disappear
			RemindersShowing = false; 
			RemindersObject.SetActive (false); //Reminders is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (MapsShowing == true) { // if the Maps screen is showing, make it disappear
			MapsShowing = false;
			MapsObject.SetActive (false); //Maps is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (HealthShowing == true) { //if the Health screen is showing, make it disappear
			HealthShowing = false;
			HealthObject.SetActive (false); //Health is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (ContactsShowing == true) { //if the Contacts screen is showing, make it disappear
			ContactsShowing = false;
			ContactsObject.SetActive (false); //Contacts is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (MailShowing == true) { //if the Mail screen is showing, make it disappear
			MailShowing = false;
			MailObject.SetActive (false); //Mail is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}

		 
		if (NewsShowing == true) { //if the News screen is showing, make it disappear
			NewsShowing = false;
			NewsObject.SetActive (false); //News is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}
			


		if (YouTubeShowing == true) { //if the YouTube screen is showing, make it disappear
			YouTubeShowing = false;
			YouTubeObject.SetActive (false); //YouTube is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}
			

		if (NotesShowing == true) { //if the Notes screen is showing, make it disappear
			NotesShowing = false;
			NotesObject.SetActive (false); //Notes is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}



		if (SnapChatShowing == true) { //if the SnapChat screen is showing, make it disappear
			SnapChatShowing = false;
			SnapChatObject.SetActive (false); //SnapChat is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (BankShowing == true) { //if the Bank screen is showing, make it disappear
			BankShowing = false;
			BankObject.SetActive (false); //Bank is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (TwitterShowing == true) { //if the Twitter screen is showing, make it disappear
			TwitterShowing = false;
			TwitterObject.SetActive (false); //Twitter is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (InstagramShowing == true) { //if the Instagram screen is showing, make it disappear
			InstagramShowing = false;
			InstagramObject.SetActive (false); //Instagram is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (TumblrShowing == true) { //if the Tumblr screen is showing, make it disappear
			TumblrShowing = false;
			TumblrObject.SetActive (false); //Tumblr is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (TinderShowing == true) { //if the Tinder screen is showing, make it disappear
			TinderShowing = false;
			TinderObject.SetActive (false); //Tinder is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (NekoAtsumeShowing == true) { //if the NekoAtsume screen is showing, make it disappear
			NekoAtsumeShowing = false;
			NekoAtsumeObject.SetActive (false); //NekoAtsume is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (PhoneShowing == true) { //if the Phone screen is showing, make it disappear
			PhoneShowing = false;
			PhoneObject.SetActive (false); //Phone is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (SafariShowing == true) { //if the Safari screen is showing, make it disappear
			SafariShowing = false;
			SafariObject.SetActive (false); //Safari is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		if (SpotifyShowing == true) { //if the Spotify screen is showing, make it disappear
			SpotifyShowing = false;
			SpotifyObject.SetActive (false); //Spotify is no longer active
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active 
				}


		//second layers! this will bring the player "out" of a room to a first level room. does not directly lead to homescreen.


		// messages second layer stuff

		if (Convo1Showing == true) { //if the convo1 screen is showing, make it disappear
			Convo1Showing = false;
			Convo1Object.SetActive (false); //convo1 is no longer active
			MessagesShowing = true; //takes the player to messages menu 
			MessagesObject.SetActive (true); // messages menu is active 
		}

		if (Convo2Showing == true) { //if the convo2 screen is showing, make it disappear
			Convo2Showing = false;
			Convo2Object.SetActive (false); //convo2 is no longer active
			MessagesShowing = true; //takes the player to messages menu 
			MessagesObject.SetActive (true); // messages menu is active
		}

		if (Convo3Showing == true) { //if the convo3 screen is showing, make it disappear
			Convo3Showing = false;
			Convo3Object.SetActive (false); //convo3 is no longer active
			MessagesShowing = true; //takes the player to messages menu 
			MessagesObject.SetActive (true); // messages menu is active
		}

		if (Convo4Showing == true) { //if the convo4 screen is showing, make it disappear
			Convo4Showing = false;
			Convo4Object.SetActive (false); //convo4 is no longer active
			MessagesShowing = true; //takes the player to messages menu 
			MessagesObject.SetActive (true); // messages menu is active
		}

		if (Convo5Showing == true) { //if the convo5 screen is showing, make it disappear
			Convo5Showing = false;
			Convo5Object.SetActive (false); //convo5 is no longer active
			MessagesShowing = true; //takes the player to messages menu 
			MessagesObject.SetActive (true); // messages menu is active
		}

		//notes second layer stuff

		if (Note1Showing == true) { //if the note1 screen is showing, make it disappear
			Note1Showing = false;
			Note1Object.SetActive (false); //note1 is no longer active
			NotesShowing = true; //takes the player to notes menu 
			NotesObject.SetActive (true); // notes menu is active
		}

		if (Note2Showing == true) { //if the note2 screen is showing, make it disappear
			Note2Showing = false;
			Note2Object.SetActive (false); //note2 is no longer active
			NotesShowing = true; //takes the player to notes menu 
			NotesObject.SetActive (true); // notes menu is active
		}

		if (Note3Showing == true) { //if the note3 screen is showing, make it disappear
			Note3Showing = false;
			Note3Object.SetActive (false); //note3 is no longer active
			NotesShowing = true; //takes the player to notes menu 
			NotesObject.SetActive (true); // notes menu is active
		}

		if (Note4Showing == true) { //if the note4 screen is showing, make it disappear
			Note4Showing = false;
			Note4Object.SetActive (false); //note4 is no longer active
			NotesShowing = true; //takes the player to notes menu 
			NotesObject.SetActive (true); // notes menu is active
		}

		if (Note5Showing == true) { //if the note5 screen is showing, make it disappear
			Note5Showing = false;
			Note5Object.SetActive (false); //note5 is no longer active
			NotesShowing = true; //takes the player to notes menu 
			NotesObject.SetActive (true); // notes menu is active
		}

		//safari second layer stuff
		if (Tab1Showing == true) { //if the Tab1 screen is showing, make it disappear
			Tab1Showing = false;
			Tab1Object.SetActive (false); //Tab1 is no longer active
			SafariShowing = true; //takes the player to safari menu 
			SafariObject.SetActive (true); // safari menu is active
		}

		if (Tab2Showing == true) { //if the Tab2 screen is showing, make it disappear
			Tab2Showing = false;
			Tab2Object.SetActive (false); //Tab2 is no longer active
			SafariShowing = true; //takes the player to safari menu 
			SafariObject.SetActive (true); // safari menu is active
		}

		if (Tab3Showing == true) { //if the Tab3 screen is showing, make it disappear
			Tab3Showing = false;
			Tab3Object.SetActive (false); //Tab3 is no longer active
			SafariShowing = true; //takes the player to safari menu 
			SafariObject.SetActive (true); // safari menu is active
		}

		if (Tab4Showing == true) { //if the Tab4 screen is showing, make it disappear
			Tab4Showing = false;
			Tab4Object.SetActive (false); //Tab4 is no longer active
			SafariShowing = true; //takes the player to safari menu 
			SafariObject.SetActive (true); // safari menu is active
		}

		if (Tab5Showing == true) { //if the Tab5 screen is showing, make it disappear
			Tab5Showing = false;
			Tab5Object.SetActive (false); //Tab5 is no longer active
			SafariShowing = true; //takes the player to safari menu 
			SafariObject.SetActive (true); // safari menu is active
		}

		if (HistoryShowing == true) { //if the History screen is showing, make it disappear
			HistoryShowing = false;
			HistoryObject.SetActive (false); //History is no longer active
			SafariShowing = true; //takes the player to safari menu 
			SafariObject.SetActive (true); // safari menu is active
		}

		//news second layer stuff

		if (News1Showing == true) { //if the news1 screen is showing, make it disappear
			News1Showing = false;
			News1Object.SetActive (false); //news1 is no longer active
			NewsShowing = true; //takes the player to news menu 
			NewsObject.SetActive (true); // news menu is active
		}

		if (News2Showing == true) { //if the news2 screen is showing, make it disappear
			News2Showing = false;
			News2Object.SetActive (false); //news2 is no longer active
			NewsShowing = true; //takes the player to news menu 
			NewsObject.SetActive (true); // news menu is active
		}

		if (News3Showing == true) { //if the news3 screen is showing, make it disappear
			News3Showing = false;
			News3Object.SetActive (false); //news3 is no longer active
			NewsShowing = true; //takes the player to news menu 
			NewsObject.SetActive (true); // news menu is active
		}

		if (News4Showing == true) { //if the news4 screen is showing, make it disappear
			News4Showing = false;
			News4Object.SetActive (false); //news4 is no longer active
			NewsShowing = true; //takes the player to news menu 
			NewsObject.SetActive (true); // news menu is active
		}

		if (News5Showing == true) { //if the news5 screen is showing, make it disappear
			News5Showing = false;
			News5Object.SetActive (false); //news5 is no longer active
			NewsShowing = true; //takes the player to news menu 
			NewsObject.SetActive (true); // news menu is active
		}

		//second layer tinder stuff 
		if (Match1Showing == true) { //if the match1 screen is showing, make it disappear
			Match1Showing = false;
			Match1Object.SetActive (false); //match1 is no longer active
			TinderShowing = true; //takes the player to tinder menu 
			TinderObject.SetActive (true); // tinder menu is active
		}

		if (Match2Showing == true) { //if the match2 screen is showing, make it disappear
			Match2Showing = false;
			Match2Object.SetActive (false); //match2 is no longer active
			TinderShowing = true; //takes the player to tinder menu 
			TinderObject.SetActive (true); // tinder menu is active
		}

		if (Match3Showing == true) { //if the match3 screen is showing, make it disappear
			Match3Showing = false;
			Match3Object.SetActive (false); //match3 is no longer active
			TinderShowing = true; //takes the player to tinder menu 
			TinderObject.SetActive (true); // tinder menu is active
		}

		if (Match4Showing == true) { //if the match4 screen is showing, make it disappear
			Match4Showing = false;
			Match4Object.SetActive (false); //match4 is no longer active
			TinderShowing = true; //takes the player to tinder menu 
			TinderObject.SetActive (true); // tinder menu is active
		}

		if (Match5Showing == true) { //if the match5 screen is showing, make it disappear
			Match5Showing = false;
			Match5Object.SetActive (false); //match5 is no longer active
			TinderShowing = true; //takes the player to tinder menu 
			TinderObject.SetActive (true); // tinder menu is active
		}

		//second layer spotify stuff

		if (Playlist1Showing == true) { //if the Playlist1 screen is showing, make it disappear
			Playlist1Showing = false;
			Playlist1Object.SetActive (false); //Playlist1 is no longer active
			SpotifyShowing = true; //takes the player to Spotify menu 
			SpotifyObject.SetActive (true); // Spotify menu is active
		}

		if (Playlist2Showing == true) { //if the Playlist2 screen is showing, make it disappear
			Playlist2Showing = false;
			Playlist2Object.SetActive (false); //Playlist2 is no longer active
			SpotifyShowing = true; //takes the player to Spotify menu 
			SpotifyObject.SetActive (true); // Spotify menu is active
		}

		if (Playlist3Showing == true) { //if the Playlist3 screen is showing, make it disappear
			Playlist3Showing = false;
			Playlist3Object.SetActive (false); //Playlist3 is no longer active
			SpotifyShowing = true; //takes the player to Spotify menu 
			SpotifyObject.SetActive (true); // Spotify menu is active
		}

		if (Playlist4Showing == true) { //if the Playlist4 screen is showing, make it disappear
			Playlist4Showing = false;
			Playlist4Object.SetActive (false); //Playlist4 is no longer active
			SpotifyShowing = true; //takes the player to Spotify menu 
			SpotifyObject.SetActive (true); // Spotify menu is active
		}

		if (Playlist5Showing == true) { //if the Playlist5 screen is showing, make it disappear
			Playlist5Showing = false;
			Playlist5Object.SetActive (false); //Playlist5 is no longer active
			SpotifyShowing = true; //takes the player to Spotify menu 
			SpotifyObject.SetActive (true); // Spotify menu is active
		}

		if (NowPlayingShowing == true) { //if the NowPlaying screen is showing, make it disappear
			NowPlayingShowing = false;
			NowPlayingObject.SetActive (false); //NowPlaying is no longer active
			SpotifyShowing = true; //takes the player to Spotify menu 
			SpotifyObject.SetActive (true); // Spotify menu is active
		}

		//second layer camera stuff
		if (FrontFacingCameraShowing == true) { //if the front camera is showing, make it disappear
			FrontFacingCameraShowing = false;
			FrontFacingCameraObject.SetActive (false); //front camera is no longer active 
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active
		}

		//second layer phone stuff

		if (VoicemailShowing == true) { //if the Voicemail is showing, make it disappear
			VoicemailShowing = false;
			VoicemailObject.SetActive (false); //Voicemail is no longer active 
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active
		}
		if (KeypadShowing == true) { //if the Keypad is showing, make it disappear
			KeypadShowing = false;
			KeypadObject.SetActive (false); //Keypad is no longer active 
			HomeScreenShowing = true; //make the home screen show 
			HomeScreenObject.SetActive (true); //make the home screen active
		}
	}







	///a lot of space between each thing to make it more organized :)









	// CLICKING ON APPS TO OPEN THEM

	public void CalendarClick (){ //on click the calendar screen appears 
		CalendarObject.SetActive (true); //calendar becomes active 
		CalendarShowing = true; //calendar screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void MessagesClick (){ //on click the messages screen appears
		MessagesObject.SetActive (true); //messages becomes active 
		MessagesShowing = true; // messages screen is showing 
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		Convo1Object.SetActive (false); //conversation 1 is not showing
		Convo1Showing = false; 
		Convo2Object.SetActive (false); //conversation 2 is not showing
		Convo2Showing = false; 
		Convo3Object.SetActive (false); //conversation 3 is not showing
		Convo3Showing = false; 
		Convo4Object.SetActive (false); //conversation 4 is not showing
		Convo4Showing = false; 
		Convo5Object.SetActive (false); //conversation 5 is not showing
		Convo5Showing = false; 
			}

	public void PhotosClick (){ //on click the photos screen appears
		PhotosObject.SetActive (true); //photos becomes active 
		PhotosShowing = true; //photos screen is showing 
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void CameraClick (){ //on click the camera screen appears 
		CameraObject.SetActive (true); //camera becomes active 
		CameraShowing = true; //camera screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		FrontFacingCameraObject.SetActive (false); //front facing camera is not the default camera screen
		FrontFacingCameraShowing = false;
			}

		
	public void WeatherClick (){ //on click the weather screen appears 
		WeatherObject.SetActive (true); //weather becomes active 
		WeatherShowing = true; //weather screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void AlarmClick (){ //on click the Alarm screen appears 
		AlarmObject.SetActive (true); //Alarm becomes active 
		AlarmShowing = true; //Alarm screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void RemindersClick (){ //on click the Reminders screen appears 
		RemindersObject.SetActive (true); //Reminders becomes active
		RemindersShowing = true; //Reminders screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void MapsClick (){ //on click the Maps screen appears 
		MapsObject.SetActive (true); //Maps becomes active 
		MapsShowing = true; //Maps screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void HealthClick (){ //on click the Health screen appears 
		HealthObject.SetActive (true); //Health becomes active 
		HealthShowing = true; //Health screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void ContactsClick (){ //on click the Contacts screen appears 
		ContactsObject.SetActive (true); //Contacts becomes active 
		ContactsShowing = true; //Contacts screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void MailClick (){ //on click the Mail screen appears 
		MailObject.SetActive (true); //Mail becomes active 
		MailShowing = true; //Mail screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void NewsClick (){ //on click the News screen appears 
		NewsObject.SetActive (true); //News becomes active 
		NewsShowing = true; //News screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		News1Object.SetActive (false); //News 1 is not showing
		News1Showing = false; 
		News2Object.SetActive (false); //News 2 is not showing
		News2Showing = false; 
		News3Object.SetActive (false); //News 3 is not showing
		News3Showing = false; 
		News4Object.SetActive (false); //News 4 is not showing
		News4Showing = false; 
		News5Object.SetActive (false); //News 5 is not showing
		News5Showing = false;
			}
		
	public void YouTubeClick (){ //on click the YouTube screen appears 
		YouTubeObject.SetActive (true); //YouTube becomes active 
		YouTubeShowing = true; //YouTube screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void NotesClick (){ //on click the Notes screen appears 
		NotesObject.SetActive (true); //Notes becomes active
		NotesShowing = true; //Notes screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		Note1Object.SetActive (false); //Note 1 is not showing
		Note1Showing = false; 
		Note2Object.SetActive (false); //Note 2 is not showing
		Note2Showing = false; 
		Note3Object.SetActive (false); //Note 3 is not showing
		Note3Showing = false; 
		Note4Object.SetActive (false); //Note 4 is not showing
		Note4Showing = false; 
		Note5Object.SetActive (false); //Note 5 is not showing
		Note5Showing = false;
			}
		
	public void SnapChatClick (){ //on click the SnapChat screen appears 
		SnapChatObject.SetActive (true); //SnapChat becomes active 
		SnapChatShowing = true; //SnapChat screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void BankClick (){ //on click the Bank screen appears 
		BankObject.SetActive (true); //Bank becomes active 
		BankShowing = true; //Bank screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void TwitterClick (){ //on click the Twitter screen appears 
		TwitterObject.SetActive (true); //Twitter becomes active 
		TwitterShowing = true; //Twitter screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}

	public void InstagramClick (){ //on click the Instagram screen appears 
		InstagramObject.SetActive (true); //Instagram becomes active 
		InstagramShowing = true; //Instagram screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void TumblrClick (){ //on click the Tumblr screen appears 
		TumblrObject.SetActive (true); //Tumblr becomes active 
		TumblrShowing = true; //Tumblr screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void TinderClick (){ //on click the Tinder screen appears 
		TinderObject.SetActive (true); //Tinder becomes active 
		TinderShowing = true; //Tinder is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		Match1Object.SetActive (false); //Match 1 is not showing
		Match1Showing = false; 
		Match2Object.SetActive (false); //Match 2 is not showing
		Match2Showing = false; 
		Match3Object.SetActive (false); //Match 3 is not showing
		Match3Showing = false; 
		Match4Object.SetActive (false); //Match 4 is not showing
		Match4Showing = false; 
		Match5Object.SetActive (false); //Match 5 is not showing
		Match5Showing = false;
			}
		
	public void NekoAtsumeClick (){ //on click the NekoAtsume screen appears 
		NekoAtsumeObject.SetActive (true); //NekoAtsume becomes active
		NekoAtsumeShowing = true; // NekoAtsume screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
			}
		
	public void PhoneClick (){ //on click the Phone screen appears 
		PhoneObject.SetActive (true); //Phone becomes active 
		PhoneShowing = true; //Phone screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		VoicemailObject.SetActive (false); //the voicemail screen does not appear when click on phone 
		VoicemailShowing = false;
		KeypadObject.SetActive (false); //the keypad screen does not appear when click on phone
		KeypadShowing = false; 
			}
		
	public void SafariClick (){ //on click the Safari screen appears 
		SafariObject.SetActive (true); //Safari becomes active 
		SafariShowing = true; //Safari screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		Tab1Object.SetActive (false); //Tab 1 is not showing
		Tab1Showing = false; 
		Tab2Object.SetActive (false); //Tab 2 is not showing
		Tab2Showing = false; 
		Tab3Object.SetActive (false); //Tab 3 is not showing
		Tab3Showing = false; 
		Tab4Object.SetActive (false); //Tab 4 is not showing
		Tab4Showing = false; 
		Tab5Object.SetActive (false); //Tab 5 is not showing
		Tab5Showing = false;
		HistoryObject.SetActive (false); //history is not showing
		HistoryShowing = false;
			}
		
	public void SpotifyClick (){ //on click the Spotify screen appears 
		SpotifyObject.SetActive (true); //Spotify becomes active 
		SpotifyShowing = true; //Spotify screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		Playlist1Object.SetActive (false); //Playlist 1 is not showing
		Playlist1Showing = false; 
		Playlist2Object.SetActive (false); //Playlist 2 is not showing
		Playlist2Showing = false; 
		Playlist3Object.SetActive (false); //Playlist 3 is not showing
		Playlist3Showing = false; 
		Playlist4Object.SetActive (false); //Playlist 4 is not showing
		Playlist4Showing = false; 
		Playlist5Object.SetActive (false); //Playlist 5 is not showing
		Playlist5Showing = false;
		NowPlayingObject.SetActive (false); //NowPlaying is not showing
		NowPlayingShowing = false;
			}

	//second layer (clicking WITHIN apps to get to deeper layers)

	//clicking to switch between cameras on camera app

	public void SwitchClick (){ //on click the front facing camera activates
		FrontFacingCameraObject.SetActive (true); //front facing camera screen appears
		FrontFacingCameraShowing = true; //front facing camera  is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		CameraObject.SetActive (false); //normal camera is gone !!
		CameraShowing = false;
		}
	public void Switch2Click (){ //on click during front camera, it will take you back to front facing camera
		FrontFacingCameraObject.SetActive (false); //front facing camera disappears
		FrontFacingCameraShowing = false; //front facing camera is GONE
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		CameraObject.SetActive (true); //normal camera is back !!
		CameraShowing = true;
	}

	//clicking on conversations on messages app

	public void Convo1Click (){ //on click the convo1 screen appears 
		Convo1Object.SetActive (true); //convo1 becomes active 
		Convo1Showing = true; //convo1 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		MessagesObject.SetActive (false);
		MessagesShowing = false;
	}

	public void Convo2Click (){ //on click the convo2 screen appears 
		Convo2Object.SetActive (true); //convo2 becomes active 
		Convo2Showing = true; //convo2 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		MessagesObject.SetActive (false);
		MessagesShowing = false;
	}

	public void Convo3Click (){ //on click the convo3 screen appears 
		Convo3Object.SetActive (true); //convo33 becomes active 
		Convo3Showing = true; //convo3 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		MessagesObject.SetActive (false);
		MessagesShowing = false;
	}

	public void Convo4Click (){ //on click the convo4 screen appears 
		Convo4Object.SetActive (true); //convo4 becomes active 
		Convo4Showing = true; //convo4 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		MessagesObject.SetActive (false);
		MessagesShowing = false;
	}

	public void Convo5Click (){ //on click the convo5 screen appears 
		Convo5Object.SetActive (true); //convo5 becomes active 
		Convo5Showing = true; //convo5 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		MessagesObject.SetActive (false);
		MessagesShowing = false;
	}

	// notes screens

	public void Note1Click (){ //on click the note1 screen appears 
		Note1Object.SetActive (true); //note1 becomes active 
		Note1Showing = true; //note1 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NotesObject.SetActive (false); // notes menu goes away so you can see the note
		NotesShowing = false;
	}

	public void Note2Click (){ //on click the note2 screen appears 
		Note2Object.SetActive (true); //note2 becomes active 
		Note2Showing = true; //note2 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NotesObject.SetActive (false); // notes menu goes away so you can see the note
		NotesShowing = false;
	}

	public void Note3Click (){ //on click the note3 screen appears 
		Note3Object.SetActive (true); //note3 becomes active 
		Note3Showing = true; //note3 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NotesObject.SetActive (false); // notes menu goes away so you can see the note
		NotesShowing = false;
	}

	public void Note4Click (){ //on click the note4 screen appears 
		Note4Object.SetActive (true); //note4 becomes active 
		Note4Showing = true; //note4 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NotesObject.SetActive (false); // notes menu goes away so you can see the note
		NotesShowing = false;
	}

	public void Note5Click (){ //on click the note5 screen appears 
		Note5Object.SetActive (true); //note5 becomes active 
		Note5Showing = true; //note5 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NotesObject.SetActive (false); // notes menu goes away so you can see the note
		NotesShowing = false;
	}

	//tinder match screens


	public void Match1Click (){ //on click the Match1 screen appears 
		Match1Object.SetActive (true); //Match1 becomes active 
		Match1Showing = true; //Match1 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		TinderObject.SetActive (false); // tinder menu goes away so you can see the match conversation
		TinderShowing = false;
	}

	public void Match2Click (){ //on click the Match2 screen appears 
		Match2Object.SetActive (true); //Match2 becomes active 
		Match2Showing = true; //Match2 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		TinderObject.SetActive (false); // tinder menu goes away so you can see the match conversation
		TinderShowing = false;
	}

	public void Match3Click (){ //on click the Match3 screen appears 
		Match3Object.SetActive (true); //Match3 becomes active 
		Match3Showing = true; //Match3 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		TinderObject.SetActive (false); // tinder menu goes away so you can see the match conversation
		TinderShowing = false;
	}

	public void Match4Click (){ //on click the Match4 screen appears 
		Match4Object.SetActive (true); //Match4 becomes active 
		Match4Showing = true; //Match4 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		TinderObject.SetActive (false); // tinder menu goes away so you can see the match conversation
		TinderShowing = false;
	}

	public void Match5Click (){ //on click the Match5 screen appears 
		Match5Object.SetActive (true); //Match5 becomes active 
		Match5Showing = true; //Match5 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		TinderObject.SetActive (false); // tinder menu goes away so you can see the match conversation
		TinderShowing = false;
	}

	//safari tabs + history screens

	public void Tab1Click (){ //on click the tab1 screen appears 
		Tab1Object.SetActive (true); //tab1 becomes active 
		Tab1Showing = true; //tab1 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SafariObject.SetActive (false); // safari menu goes away so you can see the tab
		SafariShowing = false;
	}
	public void Tab2Click (){ //on click the tab2 screen appears 
		Tab2Object.SetActive (true); //tab2 becomes active 
		Tab2Showing = true; //tab2 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SafariObject.SetActive (false); // safari menu goes away so you can see the tab
		SafariShowing = false;
	}
	public void Tab3Click (){ //on click the tab3 screen appears 
		Tab3Object.SetActive (true); //tab3 becomes active 
		Tab3Showing = true; //tab3 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SafariObject.SetActive (false); // safari menu goes away so you can see the tab
		SafariShowing = false;
	}
	public void Tab4Click (){ //on click the tab4 screen appears 
		Tab4Object.SetActive (true); //tab4 becomes active 
		Tab4Showing = true; //tab4 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SafariObject.SetActive (false); // safari menu goes away so you can see the tab
		SafariShowing = false;
	}
	public void Tab5Click (){ //on click the tab5 screen appears 
		Tab5Object.SetActive (true); //tab5 becomes active 
		Tab5Showing = true; //tab5 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SafariObject.SetActive (false); // safari menu goes away so you can see the tab
		SafariShowing = false;
	}
	public void HistoryClick (){ //on click the history screen appears 
		HistoryObject.SetActive (true); //history becomes active 
		HistoryShowing = true; //history screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SafariObject.SetActive (false); // safari menu goes away so you can see history
		SafariShowing = false;
	}

	//spotify playlist + now playing screens

	public void Playlist1Click (){ //on click the Playlist1 screen appears 
		Playlist1Object.SetActive (true); //Playlist1 becomes active 
		Playlist1Showing = true; //Playlist1 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SpotifyObject.SetActive (false); // spotify menu goes away so you can see the playlist
		SpotifyShowing = false;
	}

	public void Playlist2Click (){ //on click the Playlist2 screen appears 
		Playlist2Object.SetActive (true); //Playlist2 becomes active 
		Playlist2Showing = true; //Playlist2 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SpotifyObject.SetActive (false); // spotify menu goes away so you can see the playlist
		SpotifyShowing = false;
	}

	public void Playlist3Click (){ //on click the Playlist3 screen appears 
		Playlist3Object.SetActive (true); //Playlist3 becomes active 
		Playlist3Showing = true; //Playlist3 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SpotifyObject.SetActive (false); // spotify menu goes away so you can see the playlist
		SpotifyShowing = false;
	}

	public void Playlist4Click (){ //on click the Playlist4 screen appears 
		Playlist4Object.SetActive (true); //Playlist4 becomes active 
		Playlist4Showing = true; //Playlist4 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SpotifyObject.SetActive (false); // spotify menu goes away so you can see the playlist
		SpotifyShowing = false;
	}

	public void Playlist5Click (){ //on click the Playlist5 screen appears 
		Playlist5Object.SetActive (true); //Playlist5 becomes active 
		Playlist5Showing = true; //Playlist5 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SpotifyObject.SetActive (false); // spotify menu goes away so you can see the Playlist
		SpotifyShowing = false;
	}

	public void NowPlayingClick (){ //on click the NowPlaying screen appears 
		NowPlayingObject.SetActive (true); //NowPlaying becomes active 
		NowPlayingShowing = true; //NowPlaying screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		SpotifyObject.SetActive (false); // spotify menu goes away so you can see the NowPlaying screen
		SpotifyShowing = false;
	}

	//news stuff ??

	public void News1Click (){ //on click the news1 screen appears 
		News1Object.SetActive (true); //news1 becomes active 
		News1Showing = true; //news1 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NewsObject.SetActive (false); // news menu goes away so you can see the news article
		NewsShowing = false;
	}

	public void News2Click (){ //on click the news2 screen appears 
		News2Object.SetActive (true); //news2 becomes active 
		News2Showing = true; //news2 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NewsObject.SetActive (false); // news menu goes away so you can see the news article
		NewsShowing = false;
	}

	public void News3Click (){ //on click the news3 screen appears 
		News3Object.SetActive (true); //news3 becomes active 
		News3Showing = true; //news3 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NewsObject.SetActive (false); // news menu goes away so you can see the news article
		NewsShowing = false;
	}

	public void News4Click (){ //on click the news4 screen appears 
		News4Object.SetActive (true); //news4 becomes active 
		News4Showing = true; //news4 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NewsObject.SetActive (false); // news menu goes away so you can see the news article
		NewsShowing = false;
	}

	public void News5Click (){ //on click the news5 screen appears 
		News5Object.SetActive (true); //news5 becomes active 
		News5Showing = true; //news5 screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		NewsObject.SetActive (false); // news menu goes away so you can see the news article
		NewsShowing = false;
	}

	// phone screens 

	public void VoicemailClick (){ //on click the Voicemail screen appears 
		VoicemailObject.SetActive (true); //Voicemail becomes active 
		VoicemailShowing = true; //NowPlaying screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		PhoneObject.SetActive (false); // phone screen goes away so you can see the voicemail screen
		PhoneShowing = false;
		KeypadObject.SetActive (false); // keypad goes away so you can see the voicemail screen
		KeypadShowing = false;
	}
	public void KeypadClick (){ //on click the NowPlaying screen appears 
		KeypadObject.SetActive (true); //NowPlaying becomes active 
		KeypadShowing = true; //NowPlaying screen is showing
		HomeScreenObject.SetActive (false);
		HomeScreenShowing = false;
		PhoneObject.SetActive (false); // phone screen goes away so you can see the NowPlaying screen
		PhoneShowing = false;
		VoicemailObject.SetActive (false); // voicemail goes away so you can see the keypad screen
		VoicemailShowing = false;
	}
}