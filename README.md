# TournamentAssistant
A program designed to make it easier to coordinate tournaments for the VR rhythm game Beat Saber

**Usage Guides can be found on the wiki page of the repository**

### Installing the plugin
https://github.com/MatrikMoon/TournamentAssistant/wiki/How-to-install-the-plugin

### Coordinating a match
https://github.com/MatrikMoon/TournamentAssistant/wiki/How-To-Coordinate-a-Match

### Hosting a server
#### **(You do not need to host your own server if you don't want to. Feel free to use the Default Server!)**

#### Linux
https://github.com/MatrikMoon/TournamentAssistant/wiki/How-to-Host-a-Server-on-Linux-GUI-DE-installation

https://github.com/MatrikMoon/TournamentAssistant/wiki/How-to-Host-a-Server-on-Linux-Terminal-only-Installation

#### Windows
https://github.com/MatrikMoon/TournamentAssistant/wiki/How-to-Host-a-Server-on-Windows

### Developing a mod that should work with NJS in TA?
````csharp
using TournamentAssistant.Interop;

namespace YourMod
{
    public void OnTANoteJumpSpeedUpdate()
    {
        YourMethod += Interop.NoteJumpSpeedAPI();
    }
}
````

## Contributing?
Awesome!
Pull requests are welcome! Feel free to DM [Moon](https://discord.com/users/229408465787944970) on Discord if you have any questions or concerns!

General guidelines:
 - Make sure the plugin has been thoroughly tested.
 - Changes have to be reasoned (either in the PR, or through DMs with Moon)

Reasons these things are important is that this plugin is used by a lot of people, therefore it has to be tested properly!

## License
This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license.