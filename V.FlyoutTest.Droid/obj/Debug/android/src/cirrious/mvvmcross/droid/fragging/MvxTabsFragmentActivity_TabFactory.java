package cirrious.mvvmcross.droid.fragging;


public class MvxTabsFragmentActivity_TabFactory
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.widget.TabHost.TabContentFactory
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_createTabContent:(Ljava/lang/String;)Landroid/view/View;:GetCreateTabContent_Ljava_lang_String_Handler:Android.Widget.TabHost/ITabContentFactoryInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Cirrious.MvvmCross.Droid.Fragging.MvxTabsFragmentActivity/TabFactory, Cirrious.MvvmCross.Droid.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvxTabsFragmentActivity_TabFactory.class, __md_methods);
	}


	public MvxTabsFragmentActivity_TabFactory () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxTabsFragmentActivity_TabFactory.class)
			mono.android.TypeManager.Activate ("Cirrious.MvvmCross.Droid.Fragging.MvxTabsFragmentActivity/TabFactory, Cirrious.MvvmCross.Droid.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MvxTabsFragmentActivity_TabFactory (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxTabsFragmentActivity_TabFactory.class)
			mono.android.TypeManager.Activate ("Cirrious.MvvmCross.Droid.Fragging.MvxTabsFragmentActivity/TabFactory, Cirrious.MvvmCross.Droid.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public android.view.View createTabContent (java.lang.String p0)
	{
		return n_createTabContent (p0);
	}

	private native android.view.View n_createTabContent (java.lang.String p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
