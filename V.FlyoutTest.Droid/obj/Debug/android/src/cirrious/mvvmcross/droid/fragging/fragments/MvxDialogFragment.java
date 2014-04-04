package cirrious.mvvmcross.droid.fragging.fragments;


public abstract class MvxDialogFragment
	extends cirrious.mvvmcross.droid.fragging.fragments.eventsource.MvxEventSourceDialogFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Cirrious.MvvmCross.Droid.Fragging.Fragments.MvxDialogFragment, Cirrious.MvvmCross.Droid.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MvxDialogFragment.class, __md_methods);
	}


	public MvxDialogFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxDialogFragment.class)
			mono.android.TypeManager.Activate ("Cirrious.MvvmCross.Droid.Fragging.Fragments.MvxDialogFragment, Cirrious.MvvmCross.Droid.Fragging, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
