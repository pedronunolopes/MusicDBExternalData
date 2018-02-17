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


public class RCt_MUArtistSocialMediaRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUArtistSocialMediaRecord> {

	private static final GlobalObjectKey Idt_MUArtistSocialMedia = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*pldtpkeAzVOINld6ql+4Rg");

	public static void ensureInitialized() {}
	public ENt_MUArtistSocialMediaEntityRecord ssENt_MUArtistSocialMedia;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUArtistSocialMediaEntityRecord toStructure() {
		return ssENt_MUArtistSocialMedia;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUArtistSocialMediaRecord(ENt_MUArtistSocialMediaEntityRecord r) throws Exception {
		ssENt_MUArtistSocialMedia = (ENt_MUArtistSocialMediaEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUArtistSocialMedia.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUArtistSocialMedia.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUArtistSocialMediaRecord() {
		OptimizedAttributes = null;
		ssENt_MUArtistSocialMedia = new ENt_MUArtistSocialMediaEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(5, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUArtistSocialMedia.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUArtistSocialMedia.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUArtistSocialMedia.OptimizedAttributes;
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
		index = ssENt_MUArtistSocialMedia.read(r, index);
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
	public void readIM(RCt_MUArtistSocialMediaRecord r) throws Exception {
		this.ssENt_MUArtistSocialMedia = (ENt_MUArtistSocialMediaEntityRecord) r.ssENt_MUArtistSocialMedia.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MUArtistSocialMediaRecord)) {
			return false;
		}
		RCt_MUArtistSocialMediaRecord b = (RCt_MUArtistSocialMediaRecord) obj;
		if (!this.ssENt_MUArtistSocialMedia.equals(b.ssENt_MUArtistSocialMedia)) return false;
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
			return super.hashCode() ^ ssENt_MUArtistSocialMedia.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUArtistSocialMedia.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUArtistSocialMedia.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUArtistSocialMediaRecord duplicate() throws Exception {
		RCt_MUArtistSocialMediaRecord t = new RCt_MUArtistSocialMediaRecord();
		t.ssENt_MUArtistSocialMedia = (ENt_MUArtistSocialMediaEntityRecord) this.ssENt_MUArtistSocialMedia.duplicate();
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
			ssENt_MUArtistSocialMedia.toXml(this, recordElem, "t_MUArtistSocialMedia", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muartistsocialmedia")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUArtistSocialMedia")) variable.setValue(ssENt_MUArtistSocialMedia); else variable.setOptimized(true);
			variable.setFieldName("t_muartistsocialmedia");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUArtistSocialMediaRecord t = (RCt_MUArtistSocialMediaRecord) super.clone();
		t.ssENt_MUArtistSocialMedia = (ENt_MUArtistSocialMediaEntityRecord) this.ssENt_MUArtistSocialMedia.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistSocialMedia.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistSocialMedia.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUArtistSocialMedia)) {
			return ssENt_MUArtistSocialMedia;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUArtistSocialMedia.fillFromOther((IRecord) other.attributeGet(Idt_MUArtistSocialMedia));
	}
}
