# subPub
A simple publish subscibe system implemented in Unity.

It uses one static class to communicate amongst scripts.

Publishing and subscribing works by using eventargs classes(structs will be used later on).

Your evenargs classes implementations depend on your specific needs.

An example of an EventArgs class.
<code>
  
     public class OnApplySettingsButtonPressedEventArgs {    
    
        public float MusicVolumeLevel { get; set; }

        public float EffectsVolumeLevel { get; set; }

        }
     
</code>

Publishing: 
<code>
  
     var args=new new OnApplySettingsButtonPressedEventArgs(
          yourdatavalues...
     );
  
     pubsubsystem.PublishToListeners(args);
     
</code>

Subscription:
<code>
  
        pubsubsystem.AddListener<OnApplySettingsButtonPressedEventArgs>((o)=> {

            yourimplementation...
        
        });
     
</code>or
<code>
  
         public void yourFunction(object o){
            yourfunctionality...
         };
         ...
         pubsubsystem.AddListener<OnApplySettingsButtonPressedEventArgs>(yourFunction);
     
</code>
Get your desired data from o (derived from object) or just ignore it.



Unsubscription:
<code>
  
         public void yourFunction(object o){
            yourfunctionality...
         };
         ...
         pubsubsystem.RemoveListener<OnApplySettingsButtonPressedEventArgs>(yourFunction);
     
</code>
