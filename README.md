# Search in List View
So basically there are 2 things we need to have
<ol>
	<li>a list view with items in it.</li>
	<li>a search bar to input search query on.</li>
</ol>
and that would be very much of it.
in the XAML part, I will just include these 2 things but of course, you can be creative and manipulate the view.

[gist https://gist.github.com/adityadeshpande/1266c996fc35c378f66c395e003dc2e3]

<!--more-->

I'm more of an MVVM person and prefer keeping the Code behind clean in the xaml.cs, but you can do it either way, in the ViewModel or Code Behind. this should not matter.

[gist https://gist.github.com/adityadeshpande/9884db9c58e8043c69c9dd4744089d2a]

<img class="alignnone size-full wp-image-376 aligncenter" src="https://adityadeshpandeadi.files.wordpress.com/2018/01/ezgif-com-video-to-gif.gif" alt="Android preview. Works on iOS and UWP as well." width="320" height="569" />

In the <em><code>GetItems</code></em> method make sure you assign <em><code>_ItemsUnfiltered = _Items</code></em> . This makes sure the original contents are not operated on and on clearing the text input of search we can get back the original list. ;)
Also, make sure your ViewModel has inheritance of <em><code>INotifyPropertyChanged</code></em> so as to hit the <em><code>OnPropertyChanged(nameof(SomeCommandOrBinding))</code></em>

That would be very much of the searching thing, you can add as many filter criteria as you want in the lambda expression above. just keep ORing ( A || B ) or ANDing ( A && B ) them. (i prefer ORing).

p.s. I've used an <strong>EventToCommandBehavior </strong>to bind a command to an event of text changed, you can easily find a code for that. If you don't? feel free to drop by :)
<blockquote>update: <a href="https://adityadeshpandeadi.wordpress.com/2018/01/16/binding-events-to-command/" target="_blank" rel="noopener">Check Binding Event To Command.</a></blockquote>
<em><a href="mailto:adityadeshpande.adi@live.com">Pingback</a> for assistance, your Feedback’s are always a welcome… <span class="wp-smiley wp-emoji wp-emoji-smile" title=":)">🙂</span></em>

<strong>Regards,</strong>
<strong><a href="https://about.me/deshpandeaditya" target="_blank" rel="noopener">Aditya Deshpande</a></strong>
