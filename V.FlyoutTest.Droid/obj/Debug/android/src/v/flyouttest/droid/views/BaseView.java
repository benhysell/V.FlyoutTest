package v.flyouttest.droid.views;


public abstract class BaseView
	extends cirrious.mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("V.FlyoutTest.Droid.Views.BaseView, V.FlyoutTest.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseView.class, __md_methods);
	}


	public BaseView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaseView.class)
			mono.android.TypeManager.Activate ("V.FlyoutTest.Droid.Views.BaseView, V.FlyoutTest.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
