package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MDSocialMediaRecord implements Serializable, Cloneable, ITypedRecord<RCt_MDSocialMediaRecord> {

	private static final GlobalObjectKey Idt_MDSocialMedia = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*mKMimxJm6_v11fetPvR5TA");

	public static void ensureInitialized() {}
	public ENt_MDSocialMediaEntityRecord ssENt_MDSocialMedia;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MDSocialMediaEntityRecord toStructure() {
		return ssENt_MDSocialMedia;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MDSocialMediaRecord(ENt_MDSocialMediaEntityRecord r) throws Exception {
		ssENt_MDSocialMedia = (ENt_MDSocialMediaEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MDSocialMedia.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MDSocialMedia.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MDSocialMediaRecord() {
		OptimizedAttributes = null;
		ssENt_MDSocialMedia = new ENt_MDSocialMediaEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MDSocialMedia.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MDSocialMedia.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MDSocialMedia.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MDSocialMedia.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MDSocialMediaRecord r) throws Exception {
		this.ssENt_MDSocialMedia = (ENt_MDSocialMediaEntityRecord) r.ssENt_MDSocialMedia.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MDSocialMediaRecord)) {
			return false;
		}
		RCt_MDSocialMediaRecord b = (RCt_MDSocialMediaRecord) obj;
		if (!this.ssENt_MDSocialMedia.equals(b.ssENt_MDSocialMedia)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MDSocialMedia.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MDSocialMedia.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MDSocialMedia.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MDSocialMediaRecord duplicate() throws Exception {
		RCt_MDSocialMediaRecord t = new RCt_MDSocialMediaRecord();
		t.ssENt_MDSocialMedia = (ENt_MDSocialMediaEntityRecord) this.ssENt_MDSocialMedia.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MDSocialMedia.toXml(this, recordElem, "t_MDSocialMedia", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mdsocialmedia")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MDSocialMedia")) variable.setValue(ssENt_MDSocialMedia); else variable.setOptimized(true);
			variable.setFieldName("t_mdsocialmedia");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MDSocialMediaRecord t = (RCt_MDSocialMediaRecord) super.clone();
		t.ssENt_MDSocialMedia = (ENt_MDSocialMediaEntityRecord) this.ssENt_MDSocialMedia.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDSocialMedia.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MDSocialMedia.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MDSocialMedia)) {
			return ssENt_MDSocialMedia;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MDSocialMedia.fillFromOther((IRecord) other.attributeGet(Idt_MDSocialMedia));
	}
}
